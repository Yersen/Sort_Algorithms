using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class CoctailSort<T> : AlgorithmBase<T> where T : IComparable
    {
        //public CoctailSort(IEnumerable<T> items) : base(items) { }
        protected override void MakeSort()
        {
            int left = 0;
            int right = Items.Count - 1;

            while(left < right)
            {
                var sc = SwapCount;
                for (int i = left; i < right; i++)
                { 
                    if(Compare(Items[i], Items[i + 1]) == 1)
                    {
                        Swap(i, i + 1);
                    }
                }
                right--;

                if (sc == SwapCount)
                {
                    break;
                }

                for (int i = right; i > left; i--)
                {
                    if(Compare(Items[i], Items[i - 1]) == -1)
                    {
                        Swap(i, i - 1);
                    }
                }
                left++;

                if(sc == SwapCount)
                {
                    break;
                }
            }
        }
    }
}