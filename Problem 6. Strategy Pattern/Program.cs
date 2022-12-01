  var sort_name = new SortedSet<Person>(new CompareName());
    var sort_age = new SortedSet<Person>(new CompareAge());
    var n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        var info = Console.ReadLine().Split();
        var person = new Person(info[0], int.Parse(info[1]));
        sort_name.Add(person);
        sort_age.Add(person);
    }
    Console.WriteLine(string.Join(Environment.NewLine, sort_name));
Console.WriteLine(string.Join(Environment.NewLine, sort_age));