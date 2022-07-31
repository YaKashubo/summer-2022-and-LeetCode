using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.Remove_Element
{
    class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int[] arr = new int[nums.Length];
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i]!=val)
                {
                    arr[k] = nums[i];
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
