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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if (head.next == null) return null;
        ListNode fast = head;
        ListNode slow = head;
        int count = 1;
        
        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            count += 2;
        }
        if (fast == null) count--;
        int processed = count;
        ListNode prev = head;
        Console.WriteLine(processed);
        while (processed > n)
        {
            prev = slow;
            slow = slow.next;
            --processed;
        }
        if (slow == head)
        {
            head = head.next;
        }
        prev.next = slow.next;
        return head;
        
    }
}