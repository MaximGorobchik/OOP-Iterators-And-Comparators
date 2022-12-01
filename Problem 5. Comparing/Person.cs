using static System.Runtime.InteropServices.JavaScript.JSType;

public class Person: IComparable<Person>
{
    private string name;
    private int age;
    private string town;
    private int equals = 0;
    private int nonequals = 0;
    public Person(string Name, int Age, string Town)
    {
        this.name = Name;
        this.age = Age;
        this.town = Town;
    }
    public Person()
    {

    }
    public int CompareTo(Person person)
    {
        var result = this.name.CompareTo(person.name);
        if (result == 0 )
        {
            result = this.age.CompareTo(person.age);
        }
        if (result == 0 )
        {
            result = town.CompareTo(person.town);
        }
        return result;
    }
    public void Count_People(Person person, List<Person> list)
    {
        foreach (var p in list )
        {
            if(person.CompareTo(p) == 0)
            {
                equals++;
            }
            else
            {
                nonequals++;
            }
        }
        if (equals == 0 || equals == 1)
        {
            Console.WriteLine("No matches");
        }
        else
        Console.WriteLine($"{equals} {nonequals} {list.Count()}");

    }
}
