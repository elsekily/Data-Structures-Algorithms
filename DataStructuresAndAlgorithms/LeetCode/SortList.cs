using DataStructuresAndAlgorithms.LeetCode.InputTypes;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class SortList
    {
        public ListNode SortListSol(ListNode head)
        {
            if (head == null) return head;

            var list = new ListNode(head.val);
            head = head.next;

            while (head != null)
            {
                var curr = list;
                if (curr.val > head.val)
                {
                    list = new ListNode(head.val, list);
                }
                else
                {
                    while (curr.next != null && curr.next.val < head.val)
                        curr = curr.next;

                    var temp = curr.next;
                    curr.next = new ListNode(head.val, temp);
                }
                head = head.next;
            }
            return list;
        }
    }
}