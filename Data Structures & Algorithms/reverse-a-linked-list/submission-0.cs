/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head == null)
            return null;

        var stack = new Stack<int>();
        
        stack.Push(head.val);

        while (head.next != null)
        {
            head = head.next;
            stack.Push(head.val);
        }

        var result = new ListNode(stack.Pop(), null);
        var current = result;

        while (stack.Count != 0)
        {
            var nextEl = stack.Pop();
            
            current.next = new ListNode(nextEl, null);
            current = current.next;
        }

        return result;
    }
}
