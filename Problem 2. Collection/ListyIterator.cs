using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class ListyIterator<T>
{
    private List<T> list;
    private int index = 0;
    public ListyIterator()
    {
        this.list = new List<T>();
        this.index = 0;
    }
    public bool HasNext()
    {
        return this.index + 1 < this.list.Count;
    }
    public void Create(List<T> list1)
    {
        if (list1.Count == 0)
        {
            throw new Exception("Invalid Operation!");
        }
        else
            list1.ForEach(item => list.Add(item));
    }
    public bool Move()
    {
        if (HasNext())
        {
            this.index++;
            return true;
        }
        else
            return false;
    }
    public void Print()
    {
        if (list.Count == 0)
        {
            throw new Exception("List is empty");
        }
        else
        {
            Console.WriteLine(this.list[index]);
        }
    }
    public string PrintAll()
    {
        if (list.Count == 0)
        {
            throw new Exception("List is empty");
        }
        var sb = new StringBuilder();
        foreach (var elements in this.list)
        {
            sb.Append(elements + " ");
        }
        return sb.ToString().Trim();

    }
    public IEnumerator<T> GetEnumerator()
    {
        for (int i=0;i<this.list.Count;i++)
        {
            yield return this.list[i];
        }
    }
}
