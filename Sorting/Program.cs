using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Immutable;

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 3, 4, 0, 1, 2 };
           // int[] arrSorted = new int[5] { 0, 1, 2, 3, 4 };

            BozoSort bs2 = new BozoSort(printArr);

            arr = bs2.sort(arr).Result;

            //BubbleSort bs = new BubbleSort(printArr); //when using delegates you can pass around methods
            //arr = bs.sort(arr);

            Console.WriteLine(isSorted(arr));

        }

        public static void printArr(int[] arr)
        {
            Console.Clear();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
        public static bool isSorted(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != a[i + 1])
                {
                    return false;
                }
            }
            return true;
        }



    }
}
