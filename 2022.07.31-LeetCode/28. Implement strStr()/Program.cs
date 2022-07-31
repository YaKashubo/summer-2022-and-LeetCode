using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Implement_strStr__
{
    class Program
    {
        static void Main(string[] args)
        {
            string haystack = Console.ReadLine();
            string needle = Console.ReadLine();
            Console.WriteLine(new Solution().StrStr(haystack, needle));
        }
    }
}
