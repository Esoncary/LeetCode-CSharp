/*
 * @lc app=leetcode.cn id=203 lang=csharp
 *
 * [203] 移除链表元素
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
public class Solution203 {
    public ListNode RemoveElements(ListNode head, int val) {
        
        // while(head != null && head.val == val)
        // {
        //     head = head.next;
        // }
        // if(head == null)
        // {
        //     return head;
        // }
        // ListNode p = head.next;
        // ListNode pre = head;
        // while(p != null)
        // {
        //     if( p.val == val)
        //     {
        //         pre.next = p.next;
        //         p = pre.next;
        //     }
        //     else
        //     {
        //         pre = p;
        //         p = p.next;
        //     }
        // }
        // return head;

        //创建哑头节点
        // ListNode dummyHead = new ListNode(-1);
        // dummyHead.next = head;
        // ListNode temp = dummyHead;
        // while(temp.next != null)
        // {
        //     if(temp.next.val == val)
        //     {
        //         temp.next = temp.next.next;
        //     }
        //     else
        //     {
        //         temp = temp.next;
        //     }
        // }
        // return dummyHead.next;

        //递归
         if (head == null) {
            return head;
        }
        head.next = RemoveElements(head.next, val);
        return head.val == val ? head.next : head;
    }
}
// @lc code=end

