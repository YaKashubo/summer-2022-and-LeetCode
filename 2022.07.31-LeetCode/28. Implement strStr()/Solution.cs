using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Implement_strStr__
{
    class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if(haystack.Length<needle.Length)
            {
                return -1;
            }
            int index = -1;
            for(int i =0;i<haystack.Length;i++)
            {
                if((haystack[i] == needle[0]) || (needle==""))
                {
                    index = i;
                    for(int j=1;j<needle.Length;j++)
                    {
                        if((i+j)>=haystack.Length || haystack[i+j]!=needle[j] )
                        {
                            index = -1;
                            break;
                        }
                    }
                    if(index!=-1)
                    {
                        break;
                    }
                    
                }
                
            }
            return index;
        }
    }
}
