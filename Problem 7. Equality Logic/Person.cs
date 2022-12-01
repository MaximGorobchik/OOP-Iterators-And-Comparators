using System.Collections.Generic;
public class Person : IEqualityComparer<Person>, IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    public int CompareTo(Person other)
    {
        var result = this.Name.CompareTo(other.Name);
        if (result == 0)
        {
            result = this.Age.CompareTo(other.Age);
        }

        return result;
    }

    public override bool Equals(object person)
    {
        var obj = person as Person;
        return this.Name == obj.Name && this.Age == obj.Age;
    }
    public bool Equals(Person x, Person y)
    {
        return base.Equals(y);
    }
    public override int GetHashCode()
    {
        return this.Name.GetHashCode() + this.Age.GetHashCode();
    }
    public int GetHashCode(Person person)
    {
        return base.GetHashCode();
    }
}
