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
        int[] testArray = new int[] { 9, 1, 3, 5, 4, 2, 6, 7, 8, 10, 0 };

        public MainForm()
        {
            InitializeComponent();
            Sorting.BozoSort bs = new Sorting.BozoSort(displaySort);

            bs.sort(testArr);
            
        }

        private void displayPanel_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;  //similar to javascript canvas
            g.Clear(Color.White);
            using (SolidBrush sb = new SolidBrush(Color.Black)) // these things should be thrown away
            {
                Pen p = new Pen(Color.Tomato);

                var width = displayPanel.Width / testArray.Length;  // width of each rectangle
                // g.FillRectangle(sb, 0, 0, 100, 100);  // wrapped in using statement to toss
                for (int i = 0; i < testArray.Length; i++)
                {
                    var x = width * i;

                    var height = (testArray[i] +1) * (displayPanel.Height / testArray.Length);
                    var y = displayPanel.Height - height;
                    g.FillRectangle(sb, x, y, width, height);
                    g.DrawRectangle(p, x, y, width, height);
                  
                }
            }
        }
    }
}
