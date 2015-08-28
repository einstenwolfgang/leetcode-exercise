public class Queue
{
    Stack<int> s1 = new Stack<int>();
    Stack<int> s2 = new Stack<int>();

    // Push element x to the back of queue.
    public void Push(int x)
    {
        s1.Push(x);
    }

    // Removes the element from front of queue.
    public void Pop()
    {
        if (s2.Count > 0) s2.Pop();
        else
        {
            while (s1.Count > 0)
            {
                s2.Push(s1.Pop());
            }
            s2.Pop();
        }

    }

    // Get the front element.
    public int Peek()
    {
        if (s2.Count > 0) return s2.Peek();
        else
        {
            while (s1.Count > 0)
            {
                s2.Push(s1.Pop());
            }
            return s2.Peek();
        }
    }

    // Return whether the queue is empty.
    public bool Empty()
    {
        return s1.Count == 0 && s2.Count == 0;
    }
}