public class Stack
{
    Queue<int> q1 = new Queue<int>();
    Queue<int> q2 = new Queue<int>();

    // Push element x onto stack.
    public void Push(int x)
    {
        q1.Enqueue(x);
    }

    // Removes the element on top of the stack.
    public void Pop()
    {
        while (q1.Count > 1)
        {
            q2.Enqueue(q1.Dequeue());
        }
        q1.Dequeue();
        Queue<int> temp = q2;
        q2 = q1;
        q1 = temp;
    }

    // Get the top element.
    public int Top()
    {
        while (q1.Count > 1)
        {
            q2.Enqueue(q1.Dequeue());
        }
        return q1.Peek();
        q1.Dequeue();
        Queue<int> temp = q2;
        q2 = q1;
        q1 = temp;
    }

    // Return whether the stack is empty.
    public bool Empty()
    {
        return q1.Count == 0;
    }
}