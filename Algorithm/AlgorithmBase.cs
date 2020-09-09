using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class AlgorithmBase<T> where T : IComparable
    {
        public int SwapCount { get; protected set; } = 0;
        public int ComparisonCount { get; protected set; }

        public event EventHandler<Tuple<T, T>> CompareEvent; 
        public event EventHandler<Tuple<T, T>> SwapEvent;

        public List<T> Items { get; set; } = new List<T>();

        public AlgorithmBase(IEnumerable<T> items)
        {
            Items.AddRange(items);
        }
        protected void Swap(int positionA, int positionB)
        {
            if(positionA < Items.Count && positionB < Items.Count)
            {               
                var temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;            
                SwapCount++;
                SwapEvent?.Invoke(this, new Tuple<T, T>(Items[positionA], Items[positionB]));
            }
        }
        public TimeSpan Sort()
        {
            var timer = new Stopwatch();
            SwapCount = 0;
            timer.Start();
            MakeSort();
            timer.Stop();

            return timer.Elapsed;
        }
        protected virtual void MakeSort()
        {
            Items.Sort();
        }
        protected int Compare(T a, T b)
        {
            CompareEvent?.Invoke(this, new Tuple<T, T>(a, b));
            ComparisonCount++;
            return a.CompareTo(b);
        }
    }
}
