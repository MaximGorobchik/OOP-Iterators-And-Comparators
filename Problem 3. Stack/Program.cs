using System.Text;

try
{
    var stack = new Stack<int>();
    var inputline = Console.ReadLine();
    while (!inputline.Equals("END"))
    {
        var info = inputline.Split();
        if (info[0].Equals("Push"))
        {
            var number = info.Skip(1).Select(int.Parse).ToList();
            foreach(var numbers in number)
            {
                stack.Push(numbers);
            }
        }
        if (info[0].Equals("Pop"))
        {
            stack.Pop();
        }
        inputline = Console.ReadLine();
    }
    var sb = new StringBuilder();
    foreach (var elements in stack)
    {
        sb.AppendLine(elements.ToString());
    }
    Console.WriteLine($"{sb}{sb}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
