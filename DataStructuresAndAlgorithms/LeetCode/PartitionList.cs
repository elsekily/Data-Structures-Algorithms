using DataStructuresAndAlgorithms.LeetCode.InputTypes;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class PartitionList
    {
        public ListNode Partition(ListNode head, int x)
        {
            var smaller = new ListNode();
            var smallerPointer = smaller;
            var greater = new ListNode();
            var greaterPointer = greater;

            while (head != null)
            {
                if (head.val < x)
                {
                    smallerPointer.next = head;
                    smallerPointer = smallerPointer.next;
                }
                else
                {
                    greaterPointer.next = head;
                    greaterPointer = greaterPointer.next;
                }
                head = head.next;
            }

            smallerPointer.next = greater.next;
            greaterPointer.next = null;

            return smaller.next;
        }
    }
}
