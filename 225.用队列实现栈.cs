/*
 * @lc app=leetcode.cn id=225 lang=csharp
 *
 * [225] 用队列实现栈
 */

// @lc code=start
public class MyStack
{
    //双队列实现
    // Queue<int> q1;
    // Queue<int> q2;
    // Queue<int> tempQueue = new Queue<int>();

    //单队列实现
    Queue<int> q = new Queue<int>();
    public MyStack()
    {
        // q1 = new Queue<int>();
        // q2 = new Queue<int>();
        q = new Queue<int>();
    }

    public void Push(int x)
    {
        // q2.Enqueue(x);
        // while (q1.Count > 0)
        // {
        //     q2.Enqueue(q1.Dequeue());
        // }
        // tempQueue = q1;
        // q1 = q2;
        // q2 = tempQueue;
        int n = q.Count;
        q.Enqueue(x);
        for (int i = 0; i < n; i++)
        {
            q.Enqueue(q.Dequeue());
        }
    }

    public int Pop()
    {
        // return q1.Dequeue();
        return q.Dequeue();
    }

    public int Top()
    {
        // return q1.Peek();
        return q.Peek();
    }

    public bool Empty()
    {
        // return q1.Count == 0;
        return q.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
// @lc code=end

