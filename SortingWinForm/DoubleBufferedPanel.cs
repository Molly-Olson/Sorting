using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingWinForm
{
    internal class DoubleBufferedPanel : Panel
    {
        public DoubleBufferedPanel()
        {
            this.DoubleBuffered = true;
        }
    }
}
