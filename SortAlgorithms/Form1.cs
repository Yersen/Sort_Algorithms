﻿using Algorithm;
using Algorithm.DataStructures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithms
{
    public partial class Form1 : Form
    {
        List<SortedItem> items = new List<SortedItem>();
        public Form1()
        {
            InitializeComponent();
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(FillTextBox.Text, out int value))
            {
                var rnd = new Random();
                for (int i = 0; i < value; i++)
                {
                    var item = new SortedItem(rnd.Next(0,200),items.Count);
                    items.Add(item);
                }
            }
            RefreshItems();
            FillTextBox.Text = "";
        }

        private void DrawItems(List<SortedItem> items)
        {
            panel3.Controls.Clear();

            foreach (var item in items)
            {
                panel3.Controls.Add(item.ProgressBar);
                panel3.Controls.Add(item.Label);
            }
        }

        private void RefreshItems()
        {
            foreach (var item in items)
            {
                item.Refresh();
            }
            DrawItems(items);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AddTextBox.Text, out int value))
            {
                var item = new SortedItem(value,items.Count);
                items.Add(item);
            }
            RefreshItems();
            AddTextBox.Text = "";
        }

        private void BubbleSortButton_Click(object sender, EventArgs e)
        {
            var bubble = new BubbleSort<SortedItem>(items);
            Btn_Click(bubble);
        }

        private void Algorithm_SwapEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            var temp = e.Item1.Number;
            e.Item1.SetPosition(e.Item2.Number);
            e.Item2.SetPosition(temp);
            panel3.Refresh();
        }

        private void Algorithm_CompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Green);
            panel3.Refresh();

            Thread.Sleep(50);

            e.Item1.SetColor(Color.Blue);
            e.Item2.SetColor(Color.Blue);
            panel3.Refresh();
        }

        private void Algorithm_SetEvent(object sender , Tuple<int, SortedItem> e)
        {
            e.Item2.SetColor(Color.Red);
            panel3.Refresh();
            Thread.Sleep(20);

            e.Item2.SetPosition(e.Item1);
            panel3.Refresh();
            Thread.Sleep(20);

            e.Item2.SetColor(Color.Blue);
            panel3.Refresh();
            Thread.Sleep(20);
        }

        private void CoctailSortButton_Click(object sender, EventArgs e)
        {
            var coctail = new CoctailSort<SortedItem>(items);
            Btn_Click(coctail);
        }

        private void Btn_Click(AlgorithmBase<SortedItem> algorithm)
        {
            RefreshItems();
            for (int i = 0; i < algorithm.Items.Count; i++)//решение heapSort
            {
                algorithm.Items[i].SetPosition(i);
            }
            panel3.Refresh();
            algorithm.CompareEvent += Algorithm_CompareEvent;
            algorithm.SwapEvent += Algorithm_SwapEvent;
            algorithm.SetEvent += Algorithm_SetEvent;
            var time = algorithm.Sort();
            TimeLabel.Text = "Время:" + time.Milliseconds + " ms";
            SwapLabel.Text = "Колличество обменов:" + algorithm.SwapCount;
            CompareLabel.Text = "Колличество сравнений:" + algorithm.ComparisonCount;
        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void InsertSortButton_Click(object sender, EventArgs e)
        {
            var insert = new InsertSort<SortedItem>(items);
            Btn_Click(insert);
        }

        private void ShellSort_Click(object sender, EventArgs e)
        {
            var shell = new ShellSort<SortedItem>(items);
            Btn_Click(shell);
        }

        private void SelectionSortButton_Click(object sender, EventArgs e)
        {
            var selection = new SelectionSort<SortedItem>(items);
            Btn_Click(selection);
        }

        private void HeapSortBtn_Click(object sender, EventArgs e)
        {
            var heap = new Heap<SortedItem>(items);
            Btn_Click(heap);
        }

        private void GnomeSortButton_Click(object sender, EventArgs e)
        {
            var gnome = new GnomeSort<SortedItem>(items);
            Btn_Click(gnome);
        }

        private void TreeSortBtn_Click(object sender, EventArgs e)
        {
            var tree = new Tree<SortedItem>(items);
            Btn_Click(tree);
        }

        private void LSDRedixBtn_Click(object sender, EventArgs e)
        {
            var lsdRedix = new LSDRedixSort<SortedItem>(items);
            Btn_Click(lsdRedix);
        }

        private void MDSRedixSortBtn_Click(object sender, EventArgs e)
        {
            var msdRedix = new MSDRedixSort<SortedItem>(items);
            Btn_Click(msdRedix);
        }

        private void MergeSortBtn_Click(object sender, EventArgs e)
        {
            var merge = new MergeSort<SortedItem>(items);
            Btn_Click(merge);
        }

        private void QuickSortBtn_Click(object sender, EventArgs e)
        {
            var merge = new MergeSort<SortedItem>(items);
            Btn_Click(merge);
        }
    }
}
