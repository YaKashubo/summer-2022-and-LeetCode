using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Palindrome_Number
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            int t = x;
            int reverse=0;
            while(t>0)
            {
                reverse = reverse* 10 + t % 10;
                t /= 10;
            }
            return x == reverse;
        }
    }
}
