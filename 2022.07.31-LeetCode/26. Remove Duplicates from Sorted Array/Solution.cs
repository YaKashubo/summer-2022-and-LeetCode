using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Remove_Duplicates_from_Sorted_Array
{
    class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int k = 1;
            int[] arr = new int[nums.Length];
            arr[0] = nums[0];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    arr[k] = nums[i + 1];
                    k++;
                }
            }
            for (int i = 0; i < k; i++)
            {
                nums[i] = arr[i];
            }
            return k;
        }
    }
}
