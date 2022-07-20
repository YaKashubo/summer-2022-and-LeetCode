using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Longest_Common_Prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            Console.WriteLine(new Solution().LongestCommonPrefix(input));
        }
    }
}
