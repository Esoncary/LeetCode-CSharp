/*
 * @lc app=leetcode.cn id=141 lang=csharp
 *
 * [141] 环形链表
 */

// @lc code=start
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
public class Solution141 {
    public bool HasCycle(ListNode head) {
        //哈希表
        // Dictionary<ListNode, int> dic = new Dictionary<ListNode, int>();
        // while(head != null)
        // {
        //     if(!dic.ContainsKey(head))
        //     {
        //         dic.Add(head, 0);
        //         head = head.next;
        //     }
        //     else
        //     {
        //         return true;
        //     }
        // }
        // return false;

        //双指针
        ListNode slow = head;
        ListNode fast = head;
        while(  fast != null && fast.next != null )
        {
            slow = slow.next;
            fast = fast.next.next;
            if(fast == slow) return true;
        }
        return false;
    }
}
// @lc code=end

