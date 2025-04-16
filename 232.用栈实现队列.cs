public class MyQueue
{
    private Stack<int> s1;
    private Stack<int> s2;

    public MyQueue()
    {
        s1 = new Stack<int>();
        s2 = new Stack<int>();
    }

    public void Push(int x)
    {
        // 将s1中的所有元素转移到s2
        while (s1.Count > 0)
        {
            s2.Push(s1.Pop());
        }
        // 压入新元素到s1
        s1.Push(x);
        // 将s2中的元素转回s1，此时新元素位于栈底
        while (s2.Count > 0)
        {
            s1.Push(s2.Pop());
        }
    }

    public int Pop()
    {
        return s1.Pop();
    }

    public int Peek()
    {
        return s1.Peek();
    }

    public bool Empty()
    {
        return s1.Count == 0;
    }
}