using mtsl;
using System;

namespace mtsl {
     class Program {
        public static void Main(string[] args){
            Solution solution = new Solution();
            // int[] testCaseOneP1 = {1,2,4};
            // int[] testCaseOneP2 = {1,3,4};

            // ListNode headP1 = new ListNode(testCaseOneP1[0]);
            // ListNode currentP1 = headP1;

            // for(int i = 1; i < testCaseOneP1.Length; i++){
            //     currentP1.next = new ListNode(testCaseOneP1[i]);
            //     currentP1 = currentP1.next;
            // }
            // ListNode headP2 = new ListNode(testCaseOneP2[0]);
            // ListNode currentP2 = headP2;

            // for(int i = 1; i < testCaseOneP2.Length; i++){
            //     currentP2.next = new ListNode(testCaseOneP2[i]);
            //     currentP2 = currentP2.next;
            // }
            ListNode p1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            ListNode p2 = new ListNode(1, new ListNode(3, new ListNode(4)));
            ListNode result = solution.MergeTwoLists(p1, p2);
            while(result != null){
                Console.WriteLine(result.val);
                result = result.next;
            }
        }
    }
}
