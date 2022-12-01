try
{
    ListyIterator<string> listyIterator = new ListyIterator<string>();
    var inputline = Console.ReadLine();
    while (!inputline.Equals("END"))
    {
        var info = inputline.Split();
        if (info[0].Equals("HasNext"))
        {
            Console.WriteLine(listyIterator.HasNext());
        }
        if (info[0].Equals("Move"))
        {
            Console.WriteLine(listyIterator.Move());
        }
        if (info[0].Equals("Print"))
        {
            listyIterator.Print();
        }
        if (info[0].Equals("Create"))
        {
            listyIterator.Create(info.Skip(1).ToList());
        }
        if (info[0].Equals("PrintAll"))
        {
            Console.WriteLine(listyIterator.PrintAll());
        }
        inputline = Console.ReadLine();
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}