/*
 * @lc app=leetcode.cn id=234 lang=csharp
 *
 * [234] 回文链表
 */

// @lc code=start

using System.Text.Json;

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
public class Solution234
{
    public bool IsPalindrome(ListNode head)
    {
        //暴力解
        // ListNode p = head;
        // List<int> list = new List<int>();
        // while (p != null)
        // {
        //     list.Add(p.val);
        //     p = p.next;
        // }
        // int low = 0;
        // int heigh = list.Count - 1;
        // while (low < heigh)
        // {
        //     if (list[low] == list[heigh])
        //     {
        //         low++;
        //         heigh--;
        //     }
        //     else
        //     {
        //         return false;
        //     }
        // }
        // return true;

        //寻找中间节点（快慢指针）+反转链表
        ListNode head2 = reverseList(midHead(head));
        while (head2 != null)
        {
            if (head.val != head2.val)
            {
                return false;
            }
            head2 = head2.next;
            head = head.next;
        }
        return true;
    }
    private ListNode midHead(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;
        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }
        return slow;
    }
    private ListNode reverseList(ListNode head)
    {
        ListNode pre = head;
        ListNode cur = head.next;
        ListNode p = head;
        while (cur != null)
        {
            p.next = cur.next;
            cur.next = pre;
            pre = cur;
            cur = p.next;
        }
        return pre;
    }
}
// @lc code=end

