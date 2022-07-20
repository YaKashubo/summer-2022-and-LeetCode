using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input =Console.ReadLine().Split();
            var nums = new int[input.Length];
            for(int i =0; i<nums.Length;i++)
            {
                nums[i] = int.Parse(input[i]);
            }

            var target = int.Parse(Console.ReadLine());
            var res = new Solution().TwoSum(nums, target);
            Console.WriteLine($"[{res[0]}, {res[1]}]");
        }
    }
}
