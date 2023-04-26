using mtsl;
using System;

namespace mtsl {
    public class Solution {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
            //Printing to verify ; working as intended
            // while(list1 != null){
            //     Console.WriteLine(list1.val);
            //     list1 = list1.next;
            // }
            // while(list2 != null){
            //     Console.WriteLine(list2.val);
            //     list2 = list2.next;
            // }
            ListNode result = new ListNode(); // 0 -> null
            ListNode current = result; // 0 -> null

            //1 -> 2 -> 4 -> null
            //1 -> 3 -> 4 -> null
            while(list1 != null && list2 != null){ 
                if(list2.val > list1.val){
                    current.next = list1; 
                    list1 = list1.next;
                }else{
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }
            if (list1 != null){
                current.next = list1;
            }else if (list2 != null){
                current.next = list2;
            }
            return result.next;
        }
    }
}
