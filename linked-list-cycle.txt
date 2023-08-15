/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        HashSet<ListNode> hashSet = new HashSet<ListNode>();
        ListNode visitor = head;
        
        if (head == null) return false;
        
        while (visitor.next != null)
        {
            if (hashSet.Contains(visitor))
            {
                return true;
            }
            hashSet.Add(visitor);
            visitor = visitor.next;
        }
        if (hashSet.Contains(visitor))
        {
            return true;
        }
        return false;
    }
}