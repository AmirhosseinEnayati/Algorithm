namespace Project.Problems.LinkedList;

public class DeleteTheMiddleNode
{
    public ListNode? DeleteMiddle(ListNode head)
    {
        if (head.next is null)
            return null;

        var current = head;
        //Count nodes
        var count = 1;
        while (current.next is not null)
        {
            count++;
            current = current.next;
        }

        int middle = count / 2; 

        //Change next for the middle's previous node 
        current = head;
        while (--middle > 0)
        {
            current = current.next;
        }

        current!.next = current.next!.next;

        return head;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}