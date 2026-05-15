using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public abstract class Sort
    {
        protected Action<int[]> displayFunc;
        public Sort(Action<int[]>display)
        {
            this.displayFunc = display;
        }
       // public void setDisplay(Action<int[]> display);   //action is a delegate for methods that have no parameters and take a value in this case implementing a type int[] (array)
        public abstract Task<int[]> sort(int[] arr);
    }
}
