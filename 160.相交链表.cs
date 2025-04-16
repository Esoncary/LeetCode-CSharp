/*
 * @lc app=leetcode.cn id=160 lang=csharp
 *
 * [160] 相交链表
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution160
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        //暴力解
        ListNode nodeA = headA;
        ListNode nodeB = headB;
        //     while(nodeA != null)
        //     {
        //         nodeB = headB;
        //         while(nodeB != null)
        //         {
        //             if(nodeA == nodeB)  return nodeA;
        //             nodeB = nodeB.next;
        //         }
        //         nodeA = nodeA.next;
        //     }
        //     return null;

        //双指针 (x+z)+y = (y+z)+x
        // while (nodeA != nodeB)
        // {
        //     // 如果 nodeA 遍历完链表 A，将其指向链表 B 的头节点
        //     nodeA = (nodeA == null) ? headB : nodeA.next;
        //     // 如果 nodeB 遍历完链表 B，将其指向链表 A 的头节点
        //     nodeB = (nodeB == null) ? headA : nodeB.next;
        // }
        // return nodeA;

        //hash
        Dictionary<ListNode, int> dic = new Dictionary<ListNode, int>();
        while (nodeA != null)
        {
            dic.Add(nodeA, 1);
            nodeA = nodeA.next;
        }
        while(nodeB != null && !dic.ContainsKey(nodeB))
        {
            nodeB = nodeB.next;
        }
        return nodeB;
    }
}
// @lc code=end

