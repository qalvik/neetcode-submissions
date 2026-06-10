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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        var head = new ListNode(0, null);
        
        if (list1 == null && list2 == null)
            return null;
        else if (list2 == null)
            return list1;
        else if (list1 == null)
            return list2;
        
        if (list1.val > list2.val)
        {
            head = new ListNode(list2.val, null);
            list2 = list2.next;
        }
        else 
        {
            head = new ListNode(list1.val, null);
            list1 = list1.next;
        }    

        var prev = head;
        var current = head;

        while (list1 != null && list2 != null)
        {
            if (list1.val > list2.val)
            {
                current = new ListNode(list2.val, null);
                prev.next = current;
                prev = current;

                list2 = list2.next;
            }
            else 
            {
                current = new ListNode(list1.val, null);
                prev.next = current;
                prev = current;

                list1 = list1.next;
            }
        }
        
        current.next = list1 ?? list2;

        return head;
    }
}