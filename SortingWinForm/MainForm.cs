using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingWinForm
{
    public partial class MainForm : Form
    {
        int[] testArr = new int[] { 9, 1, 3, 5, 4, 2, 6, 7, 8, 10, 0 };

        public MainForm()
        {
            InitializeComponent();
            Sorting.BozoSort bs = new Sorting.BozoSort(displaySort);

            Random.Shared.Shuffle(testArr);  // shuffle the array before sorting

            bs.sort(testArr);
            
        }
        public void displaySort(int[] arr)
        {
            displayPanel.Invalidate();
        }

        private void displayPanel_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;  //similar to javascript canvas
            g.Clear(Color.White);
            using (SolidBrush sb = new SolidBrush(Color.Black)) // these things should be thrown away
            {
                Pen p = new Pen(Color.Tomato);

                var width = displayPanel.Width / testArr.Length;  // width of each rectangle
                // g.FillRectangle(sb, 0, 0, 100, 100);  // wrapped in using statement to toss
                for (int i = 0; i < testArr.Length; i++)
                {
                    var x = width * i;

                    var height = (testArr[i] +1) * (displayPanel.Height / testArr.Length);
                    var y = displayPanel.Height - height;
                    g.FillRectangle(sb, x, y, width, height);
                    g.DrawRectangle(p, x, y, width, height);
                  
                }
            }
        }
    }
}
