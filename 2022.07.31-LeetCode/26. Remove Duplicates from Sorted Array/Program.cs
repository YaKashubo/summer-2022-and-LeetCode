using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Remove_Duplicates_from_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n];
            var input = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
            }
            int k = new Solution().RemoveDuplicates(arr);
            Console.WriteLine(k);
            Console.Write("[");
            for(int i =0;i<k;i++)
            {
                Console.Write($"{arr[i]},");
            }
            Console.Write("]");
        }
    }
}
