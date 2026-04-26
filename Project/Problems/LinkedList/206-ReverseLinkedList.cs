namespace Project.Problems.LinkedList;

public class ReverseLinkedList
{
    public ListNode ReverseList(ListNode head)
    {
        var currHead = head;
        while (head.next is not null)
        {
            var prevHead = currHead;
            currHead = head.next;
            head.next = currHead.next;
            currHead.next = prevHead;
        }
        return currHead;
    }
}