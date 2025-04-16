/*
 * @lc app=leetcode.cn id=206 lang=csharp
 *
 * [206] 反转链表
 */

// @lc code=start
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
public class Solution206
{
    public ListNode ReverseList(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }
        //迭代1
        // ListNode pre = head;
        // ListNode p = head.next;
        // while (p != null)
        // {
        //     pre.next = p.next;
        //     p.next = head;
        //     head = p;
        //     p = pre.next;
        // }
        // return head;

        //迭代2
        // ListNode pre = null;
        // ListNode cur = head;
        // while (cur != null)
        // {
        //     ListNode temp = cur.next;
        //     cur.next = pre;
        //     pre = cur;
        //     cur = temp;
        // }
        // return pre;


        //递归(根據迭代2)
        return ReverseList(null, head);
    }
    public ListNode ReverseList(ListNode pre, ListNode cur)
    {
        if (cur == null)
        {
            return pre;
        }
        ListNode temp = cur.next;
        cur.next = pre;
        return ReverseList(cur, temp);
    }
}
// @lc code=end

