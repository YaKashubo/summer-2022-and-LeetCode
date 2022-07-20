using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Longest_Common_Prefix
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            int min = 201;
            string s="";
            for(int i=0; i<strs.Length;i++)
            {
                if(strs[i].Length<min)
                {
                    min = strs[i].Length;
                }
            }
            bool fl = true;
            for(int i=0;i<min;i++)
            {
                for(int j=1;j<strs.Length;j++)
                {
                    if (strs[0][i]!=strs[j][i])
                    {
                        fl = false;
                        break;
                    }
                }
                if(fl)
                {
                    s += strs[0][i];
                }
                else
                {
                    return s;
                }
            }
            return s;
        }
    }
}
