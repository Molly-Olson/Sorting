using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class InsertionSort : Sort
    {
        public InsertionSort(Action<int[]> display) : base(display)
        {
        }
        public override async Task<int[]> sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;  // this moves the index back to find the correct position for the key
                    await Task.Delay(500);
                    displayFunc(arr);
                }
                arr[j + 1] = key;
                await Task.Delay(500);
                displayFunc(arr);
            }
            return arr;
        }
    }
}
