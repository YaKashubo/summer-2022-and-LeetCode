using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Merge_Two_Sorted_Lists
{
    
    
     public class ListNode {
         public int val;
         public ListNode next;
         public ListNode(int val=0, ListNode next=null) {
             this.val = val;
             this.next = next;
         }
     }
    
    public class Solution
    {
        static public ListNode SortList(ListNode list)
        {
            ListNode head = new ListNode();
            ListNode t = new ListNode(); 
            ListNode temp = new ListNode();
            head = list;
            while((t=list.next)!=null)
            {
                while(t!=null)
                {
                    if(t.val<list.val)
                    {
                        temp = list.next;
                        list.next = t.next;
                        t.next = temp;
                    }
                    t = t.next;
                }
                list = list.next;
            }
            list = head;
            return list; 
        }
        
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode list = list1;
            ListNode temp = list;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = list2;
            return SortList(list);
        }
    }
}
