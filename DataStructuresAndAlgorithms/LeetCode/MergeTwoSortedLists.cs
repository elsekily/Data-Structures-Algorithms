using DataStructuresAndAlgorithms.LeetCode.InputTypes;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;

            if (l2 == null)
                return l1;

            ListNode head = new ListNode();
            var output = head;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    output.next = new ListNode(l1.val);
                    l1 = l1.next;
                }
                else
                {
                    output.next = new ListNode(l2.val);
                    l2 = l2.next;
                }
                output = output.next;
            }
            if (l1 != null)
                output.next = l1;
            if (l2 != null)
                output.next = l2;

            return head.next;
        }
    }
}