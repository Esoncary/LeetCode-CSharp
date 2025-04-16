/*
 * @lc app=leetcode.cn id=83 lang=csharp
 *
 * [83] 删除排序链表中的重复元素
 */

// @lc code=start

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
public class Solution83
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null) return null;
        ListNode i = head;
        ListNode j = head.next;
        while (i.next != null)
        {
            if (i.val == j.val)
            {
                i.next = j.next;
                j = j.next;
            }
            else
            {
                i = j;
                j = j.next;
            }
        }
        return head;
    }
}
// @lc code=end

