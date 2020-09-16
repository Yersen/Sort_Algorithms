namespace SortAlgorithms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FillButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FillTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BubbleSortButton = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.CompareLabel = new System.Windows.Forms.Label();
            this.SwapLabel = new System.Windows.Forms.Label();
            this.CoctailSortButton = new System.Windows.Forms.Button();
            this.InsertSortButton = new System.Windows.Forms.Button();
            this.ShellSort = new System.Windows.Forms.Button();
            this.SelectionSortButton = new System.Windows.Forms.Button();
            this.HeapSortBtn = new System.Windows.Forms.Button();
            this.GnomeSortButton = new System.Windows.Forms.Button();
            this.TreeSortBtn = new System.Windows.Forms.Button();
            this.LSDRedixBtn = new System.Windows.Forms.Button();
            this.MDSRedixSortBtn = new System.Windows.Forms.Button();
            this.MergeSortBtn = new System.Windows.Forms.Button();
            this.QuickSortBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.AddTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 80);
            this.panel1.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(172, 24);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(7, 25);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(159, 22);
            this.AddTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить число";
            // 
            // FillButton
            // 
            this.FillButton.Location = new System.Drawing.Point(172, 28);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(94, 23);
            this.FillButton.TabIndex = 1;
            this.FillButton.Text = "Заполнить";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Заполнить случайными числами";
            // 
            // FillTextBox
            // 
            this.FillTextBox.Location = new System.Drawing.Point(7, 29);
            this.FillTextBox.Name = "FillTextBox";
            this.FillTextBox.Size = new System.Drawing.Size(159, 22);
            this.FillTextBox.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.FillTextBox);
            this.panel2.Controls.Add(this.FillButton);
            this.panel2.Location = new System.Drawing.Point(12, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 101);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(284, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1011, 187);
            this.panel3.TabIndex = 5;
            // 
            // BubbleSortButton
            // 
            this.BubbleSortButton.Location = new System.Drawing.Point(11, 217);
            this.BubbleSortButton.Name = "BubbleSortButton";
            this.BubbleSortButton.Size = new System.Drawing.Size(120, 35);
            this.BubbleSortButton.TabIndex = 6;
            this.BubbleSortButton.Text = "BubbleSort";
            this.BubbleSortButton.UseVisualStyleBackColor = true;
            this.BubbleSortButton.Click += new System.EventHandler(this.BubbleSortButton_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(13, 255);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(54, 17);
            this.TimeLabel.TabIndex = 7;
            this.TimeLabel.Text = "Время:";
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // CompareLabel
            // 
            this.CompareLabel.AutoSize = true;
            this.CompareLabel.Location = new System.Drawing.Point(13, 272);
            this.CompareLabel.Name = "CompareLabel";
            this.CompareLabel.Size = new System.Drawing.Size(172, 17);
            this.CompareLabel.TabIndex = 8;
            this.CompareLabel.Text = "Колличество сравнений:";
            // 
            // SwapLabel
            // 
            this.SwapLabel.AutoSize = true;
            this.SwapLabel.Location = new System.Drawing.Point(13, 289);
            this.SwapLabel.Name = "SwapLabel";
            this.SwapLabel.Size = new System.Drawing.Size(150, 17);
            this.SwapLabel.TabIndex = 9;
            this.SwapLabel.Text = "Количество обменов:";
            // 
            // CoctailSortButton
            // 
            this.CoctailSortButton.Location = new System.Drawing.Point(137, 216);
            this.CoctailSortButton.Name = "CoctailSortButton";
            this.CoctailSortButton.Size = new System.Drawing.Size(113, 36);
            this.CoctailSortButton.TabIndex = 10;
            this.CoctailSortButton.Text = "CoctailSort";
            this.CoctailSortButton.UseVisualStyleBackColor = true;
            this.CoctailSortButton.Click += new System.EventHandler(this.CoctailSortButton_Click);
            // 
            // InsertSortButton
            // 
            this.InsertSortButton.Location = new System.Drawing.Point(256, 216);
            this.InsertSortButton.Name = "InsertSortButton";
            this.InsertSortButton.Size = new System.Drawing.Size(101, 36);
            this.InsertSortButton.TabIndex = 11;
            this.InsertSortButton.Text = "InsertSort";
            this.InsertSortButton.UseVisualStyleBackColor = true;
            this.InsertSortButton.Click += new System.EventHandler(this.InsertSortButton_Click);
            // 
            // ShellSort
            // 
            this.ShellSort.Location = new System.Drawing.Point(363, 216);
            this.ShellSort.Name = "ShellSort";
            this.ShellSort.Size = new System.Drawing.Size(97, 36);
            this.ShellSort.TabIndex = 12;
            this.ShellSort.Text = "ShellSort";
            this.ShellSort.UseVisualStyleBackColor = true;
            this.ShellSort.Click += new System.EventHandler(this.ShellSort_Click);
            // 
            // SelectionSortButton
            // 
            this.SelectionSortButton.Location = new System.Drawing.Point(466, 216);
            this.SelectionSortButton.Name = "SelectionSortButton";
            this.SelectionSortButton.Size = new System.Drawing.Size(102, 36);
            this.SelectionSortButton.TabIndex = 13;
            this.SelectionSortButton.Text = "SelectionSort";
            this.SelectionSortButton.UseVisualStyleBackColor = true;
            this.SelectionSortButton.Click += new System.EventHandler(this.SelectionSortButton_Click);
            // 
            // HeapSortBtn
            // 
            this.HeapSortBtn.Location = new System.Drawing.Point(574, 216);
            this.HeapSortBtn.Name = "HeapSortBtn";
            this.HeapSortBtn.Size = new System.Drawing.Size(89, 36);
            this.HeapSortBtn.TabIndex = 14;
            this.HeapSortBtn.Text = "HeapSort";
            this.HeapSortBtn.UseVisualStyleBackColor = true;
            this.HeapSortBtn.Click += new System.EventHandler(this.HeapSortBtn_Click);
            // 
            // GnomeSortButton
            // 
            this.GnomeSortButton.Location = new System.Drawing.Point(669, 216);
            this.GnomeSortButton.Name = "GnomeSortButton";
            this.GnomeSortButton.Size = new System.Drawing.Size(91, 36);
            this.GnomeSortButton.TabIndex = 15;
            this.GnomeSortButton.Text = "GnomeSort";
            this.GnomeSortButton.UseVisualStyleBackColor = true;
            this.GnomeSortButton.Click += new System.EventHandler(this.GnomeSortButton_Click);
            // 
            // TreeSortBtn
            // 
            this.TreeSortBtn.Location = new System.Drawing.Point(766, 216);
            this.TreeSortBtn.Name = "TreeSortBtn";
            this.TreeSortBtn.Size = new System.Drawing.Size(91, 36);
            this.TreeSortBtn.TabIndex = 16;
            this.TreeSortBtn.Text = "TreeSort";
            this.TreeSortBtn.UseVisualStyleBackColor = true;
            this.TreeSortBtn.Click += new System.EventHandler(this.TreeSortBtn_Click);
            // 
            // LSDRedixBtn
            // 
            this.LSDRedixBtn.Location = new System.Drawing.Point(863, 217);
            this.LSDRedixBtn.Name = "LSDRedixBtn";
            this.LSDRedixBtn.Size = new System.Drawing.Size(115, 35);
            this.LSDRedixBtn.TabIndex = 17;
            this.LSDRedixBtn.Text = "LSDRedixSort";
            this.LSDRedixBtn.UseVisualStyleBackColor = true;
            this.LSDRedixBtn.Click += new System.EventHandler(this.LSDRedixBtn_Click);
            // 
            // MDSRedixSortBtn
            // 
            this.MDSRedixSortBtn.Location = new System.Drawing.Point(984, 217);
            this.MDSRedixSortBtn.Name = "MDSRedixSortBtn";
            this.MDSRedixSortBtn.Size = new System.Drawing.Size(116, 35);
            this.MDSRedixSortBtn.TabIndex = 18;
            this.MDSRedixSortBtn.Text = "MDSRedixSort";
            this.MDSRedixSortBtn.UseVisualStyleBackColor = true;
            this.MDSRedixSortBtn.Click += new System.EventHandler(this.MDSRedixSortBtn_Click);
            // 
            // MergeSortBtn
            // 
            this.MergeSortBtn.Location = new System.Drawing.Point(1106, 217);
            this.MergeSortBtn.Name = "MergeSortBtn";
            this.MergeSortBtn.Size = new System.Drawing.Size(87, 35);
            this.MergeSortBtn.TabIndex = 19;
            this.MergeSortBtn.Text = "MergeSort";
            this.MergeSortBtn.UseVisualStyleBackColor = true;
            this.MergeSortBtn.Click += new System.EventHandler(this.MergeSortBtn_Click);
            // 
            // QuickSortBtn
            // 
            this.QuickSortBtn.Location = new System.Drawing.Point(1199, 217);
            this.QuickSortBtn.Name = "QuickSortBtn";
            this.QuickSortBtn.Size = new System.Drawing.Size(96, 35);
            this.QuickSortBtn.TabIndex = 20;
            this.QuickSortBtn.Text = "QuickSort";
            this.QuickSortBtn.UseVisualStyleBackColor = true;
            this.QuickSortBtn.Click += new System.EventHandler(this.QuickSortBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 450);
            this.Controls.Add(this.QuickSortBtn);
            this.Controls.Add(this.MergeSortBtn);
            this.Controls.Add(this.MDSRedixSortBtn);
            this.Controls.Add(this.LSDRedixBtn);
            this.Controls.Add(this.TreeSortBtn);
            this.Controls.Add(this.GnomeSortButton);
            this.Controls.Add(this.HeapSortBtn);
            this.Controls.Add(this.SelectionSortButton);
            this.Controls.Add(this.ShellSort);
            this.Controls.Add(this.InsertSortButton);
            this.Controls.Add(this.CoctailSortButton);
            this.Controls.Add(this.SwapLabel);
            this.Controls.Add(this.CompareLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.BubbleSortButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FillTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BubbleSortButton;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label CompareLabel;
        private System.Windows.Forms.Label SwapLabel;
        private System.Windows.Forms.Button CoctailSortButton;
        private System.Windows.Forms.Button InsertSortButton;
        private System.Windows.Forms.Button ShellSort;
        private System.Windows.Forms.Button SelectionSortButton;
        private System.Windows.Forms.Button HeapSortBtn;
        private System.Windows.Forms.Button GnomeSortButton;
        private System.Windows.Forms.Button TreeSortBtn;
        private System.Windows.Forms.Button LSDRedixBtn;
        private System.Windows.Forms.Button MDSRedixSortBtn;
        private System.Windows.Forms.Button MergeSortBtn;
        private System.Windows.Forms.Button QuickSortBtn;
    }
}