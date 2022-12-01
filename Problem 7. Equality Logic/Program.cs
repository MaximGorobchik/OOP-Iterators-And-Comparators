    var sorted_set = new SortedSet<Person>();
    var hash_set = new HashSet<Person>();
    var n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        var info = Console.ReadLine().Split();
        var person = new Person(info[0], int.Parse(info[1]));
        sorted_set.Add(person);
        hash_set.Add(person);
    }
    Console.WriteLine(sorted_set.Count);
    Console.WriteLine(hash_set.Count);