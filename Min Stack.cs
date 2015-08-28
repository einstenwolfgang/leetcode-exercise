public class MinStack {
    Stack<int> stack = new Stack<int>();
    Stack<int> min = new Stack<int>();
    int res;
    public void Push(int x) {
        stack.Push(x);
        if(min.Count == 0 || min.Peek()>=x){
            min.Push(x);
        }
    }

    public void Pop() {
        if (min.Peek() == stack.Peek())
        min.Pop();
        stack.Pop();
    }

    public int Top() {
        return stack.Peek();
    }

    public int GetMin() {
        return min.Peek();
    }
}