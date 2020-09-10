using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithms
{
    public class SortedItem : IComparable
    {
        public VerticalProgressBar.VerticalProgressBar ProgressBar { get; private set; }
        public Label Label { get; private set; }
        public int Value { get; private set; }
        public int Number { get; private set; }
        public int StartNumber { get; private set; }
        public SortedItem(int value, int number)
        {
            Value = value;
            Number = number;
            StartNumber = number;
            ProgressBar = new VerticalProgressBar.VerticalProgressBar();
            Label = new Label();
            var x = number * 22;
            // verticalProgressBar1
            // 
            ProgressBar.BorderStyle = VerticalProgressBar.BorderStyles.Classic;
            ProgressBar.Color = System.Drawing.Color.Blue;
            ProgressBar.Location = new System.Drawing.Point(x, 4);
            ProgressBar.Maximum = 200;
            ProgressBar.Minimum = 0;
            ProgressBar.Name = "verticalProgressBar" + number;
            ProgressBar.Size = new System.Drawing.Size(21, 132);
            ProgressBar.Step = 1;
            ProgressBar.Style = VerticalProgressBar.Styles.Solid;
            ProgressBar.TabIndex = number;
            ProgressBar.Value = Value;
            // 
            // label3
            // 
            Label.AutoSize = true;
            Label.Location = new System.Drawing.Point(x, 139);
            Label.Name = "label" + number;
            Label.Size = new System.Drawing.Size(24, 17);
            Label.TabIndex = number;
            Label.Text = Value.ToString();
        }

        public void SetPosition(int number)
        {
            Number = number;
            var x = number * 22;
            ProgressBar.Name = "verticalProgressBar" + number;
            ProgressBar.Location = new System.Drawing.Point(x, 4);
            Label.Name = "label" + number;
            Label.Location = new Point(x, 139);
        }

        public void Refresh()
        {
            Number = StartNumber;
            var x = Number * 22;
            ProgressBar.Name = "verticalProgressBar" + Number;
            ProgressBar.Location = new System.Drawing.Point(x, 4);
            Label.Name = "label" + Number;
            Label.Location = new Point(x, 139);
        }

        public void SetColor(Color color)
        {
            ProgressBar.Color = color;
           
        }
        public int CompareTo(object obj)
        {
            if(obj is SortedItem item)
            {
                return Value.CompareTo(item.Value);
            }
            else
            {
                throw new ArgumentException($"obj is not {nameof(SortedItem)}", nameof(obj));
            }
        }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
