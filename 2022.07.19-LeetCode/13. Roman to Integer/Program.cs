using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Roman_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(new Solution().RomanToInt(s));
        }
    }
}
