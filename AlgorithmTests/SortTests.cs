using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.DataStructures;

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
            for (int i = 0; i < 10000; i++)
            {
                items.Add(rnd.Next(0, 1000));
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

        [TestMethod()]
        public void ShellSortTest()
        {
            var shell = new ShellSort<int>();
            shell.Items.AddRange(items);
            shell.Sort();
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], shell.Items[i]);
            }
        }

        [TestMethod()]
        public void BaseSortTest()
        {
            var baseSort = new AlgorithmBase<int>();
            baseSort.Items.AddRange(items);
            baseSort.Sort();
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], baseSort.Items[i]);
            }
        }
        [TestMethod()]
        public void TreeSortTest()
        {
            var tree = new TreeSort<int>();
            tree.Items.AddRange(items);
            tree.Sort();
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], tree.Items[i]);
            }
        }
        [TestMethod()]
        public void HeapSortTest()
        {
            var heap = new Heap<int>(items);
            heap.Sort();
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], heap.Items[i]);
            }
        }

        [TestMethod()]
        public void SelectionSortTest()
        {
            var selection = new SelectionSort<int>();
            selection.Items.AddRange(items);
            selection.Sort();
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], selection.Items[i]);
            }
        }
    }
}