using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class LSDRedixSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public LSDRedixSort(IEnumerable<T> items) : base(items) { }

        public LSDRedixSort() { }
        protected override void MakeSort()
        {
            var groups = new List<List<T>>();
            for (int i = 0; i < 10; i++)
            {
                groups.Add(new List<T>());
            }

            int length = GetMaxLength();

            for (int step = 0; step < length; step++)
            {
                //распределение элементов по корзинам
                foreach (var item in Items)
                {
                    var i = item.GetHashCode();
                    var value = i % (int)Math.Pow(10, (step + 1)) / (int)Math.Pow(10, step);
                    groups[value].Add(item);
                }
                var j = 0;
                //Сборка элементов 
                foreach (var group in groups)
                {
                    foreach (var item in group)
                    {
                        Set(j, item);
                        j++;
                    }
                }
                //Очистка корзин
                foreach (var group in groups)
                {
                    group.Clear();
                }
            }
        }

        private int GetMaxLength()
        {
            var lenght = 0;
            foreach (var item in Items)
            {
                if (item.GetHashCode() < 0)
                {
                    throw new ArgumentException("Подразрядная сортировка принимает только целые числа больше нуля", nameof(Items));
                }
                //var l = Convert.ToInt32(Math.Log10(item.GetHashCode()) + 1);//не работает со значением item = 0,выходит -infinity
                var l = item.GetHashCode().ToString().Length;//вычисление максимальной длины
                if (l > lenght)
                {
                    lenght = l;
                }
            }
            return lenght;
        }
    }
}
