namespace Project.Problems.LinkedList;

public class MaxTwinSumOfALinkedList
{
    public int PairSum(ListNode head)
    {
        int max = 0, count = 0;
        var curr = head;
        while (curr is not null)
        {
            count++;
            curr = curr.next;
        }

        var twinLeftSide = new int[count / 2];
        count = 0;
        curr = head;
        while (curr is not null)
        {
            if (count < twinLeftSide.Length)
            {
                twinLeftSide[count] = curr.val;
            }
            else
            {
                var sum = twinLeftSide[twinLeftSide.Length * 2 - 1 - count] + curr.val;
                if (sum > max)
                    max = sum;
            }
            count++;
            curr = curr.next;
        }

        return max;
    }

    /* 
     * *** Best solution ***
     * Find middle of the list by slow/fast pointers
     * Reverse second half
     * Compute max twin sum
     * 
     * public int PairSum(ListNode head)
      {
          // 1. Find middle of the list
          ListNode slow = head;
          ListNode fast = head;

          while (fast != null && fast.next != null)
          {
              slow = slow.next;
              fast = fast.next.next;
          }

          // 2. Reverse second half
          ListNode prev = null;
          ListNode curr = slow;
          while (curr != null)
          {
              ListNode nextNode = curr.next;
              curr.next = prev;
              prev = curr;
              curr = nextNode;
          }

          // 3. Compute max twin sum
          int maxSum = 0;
          ListNode first = head;
          ListNode second = prev;

          while (second != null)
          {
              maxSum = Math.Max(maxSum, first.val + second.val);
              first = first.next;
              second = second.next;
          }

          return maxSum;
      }*/
}