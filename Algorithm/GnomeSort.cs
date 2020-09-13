using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class GnomeSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public GnomeSort(IEnumerable<T> items) : base(items) { }

        public GnomeSort() { }

        protected override void MakeSort()
        {
            var i = 1;
            while (i < Items.Count)
            {
                if(i == 0 || Compare(Items[i], Items[i-1]) == 1 || Compare(Items[i], Items[i - 1]) == 0)
                {
                    i++;//сравниваем 1 и 0 элмт , если 1 больше идем дальше
                }
                else
                {
                    Swap(i, i - 1);//иначе меняем их местами
                    i--;//иначе меняем их местам и делаем шаг назад
                }
            }
        }
    }
}
