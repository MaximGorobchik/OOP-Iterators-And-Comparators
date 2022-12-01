using System.Collections;

public class Stack<T> : IEnumerable<T>
{
    private List<T> stack;
    public Stack()
    {
        stack = new List<T>();
    }

    public void Push(T element)
    {
        /*list.ForEach(elements => stack.Add(elements));*/
        this.stack.Insert(0, element);
    }
    public void Pop()
    {
        if (stack.Count == 0)
        {
            throw new Exception("No elements");
        }
        var last_element = this.stack[0];
        this.stack.RemoveAt(0);
    }
    public IEnumerator<T> GetEnumerator()
    {
        return this.stack.GetEnumerator();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
