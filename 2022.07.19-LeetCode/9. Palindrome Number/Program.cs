﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num =int.Parse( Console.ReadLine());
            Console.WriteLine(new Solution().IsPalindrome(num));
        }
    }
}
