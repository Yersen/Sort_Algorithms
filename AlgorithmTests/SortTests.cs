using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Tests
{
    [TestClass()]
    public class SortTests
    {
        
        Random rnd = new Random();
        List<int> items = new List<int>();
        List<int> sorted = new List<int>();
        [TestInitialize]
        public void Init()
        {
            items.Clear();
            for (int i = 0; i < 1000; i++)
            {
                items.Add(rnd.Next(0, 100));
            }
            sorted.Clear();
            sorted.AddRange(items.OrderBy(x => x).ToArray());
        }

        [TestMethod()]
        public void BubbleSortTest()
        {
            var bubble = new BubbleSort<int>();
            bubble.Items.AddRange(items);
            bubble.Sort();
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], bubble.Items[i]);
            }
        }
        [TestMethod()]
        public void CoctailSortTest()
        {
            var coctail = new CoctailSort<int>();
            coctail.Items.AddRange(items);
            coctail.Sort();
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], coctail.Items[i]);
            }
        }
        [TestMethod()]
        public void InsertSortTest()
        {
            var insert = new InsertSort<int>();
            insert.Items.AddRange(items);
            insert.Sort();
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], insert.Items[i]);
            }
        }
    }
}