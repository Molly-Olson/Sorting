using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class MergeSort : Sort
    {
        public MergeSort(Action<int[]> display) : base(display)
        {
        }
        public override async Task<int[]> sort(int[] arr)
        {
            if (arr.Length <= 1)
            {
                return arr;
            }
            int mid = arr.Length / 2;
            int[] left = arr.Take(mid).ToArray();
            int[] right = arr.Skip(mid).ToArray();
            left = await sort(left);
            right = await sort(right);
            return await merge(left, right);
        }
        private async Task<int[]> merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int i = 0, j = 0, k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    result[k++] = left[i++];
                }
                else
                {
                    result[k++] = right[j++];
                }
                await Task.Delay(500);
                displayFunc(result);
            }
            while (i < left.Length)
            {
                result[k++] = left[i++];
                await Task.Delay(500);
                displayFunc(result);
            }
            while (j < right.Length)
            {
                result[k++] = right[j++];
                await Task.Delay(500);
                displayFunc(result);
            }
            return result;
        }
    }
}
