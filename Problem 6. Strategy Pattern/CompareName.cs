using System.Collections.Generic;
public class CompareName : IComparer<Person>
{
    public int Compare(Person person1, Person person2)
    {
        var compare = person1.Name.Length.CompareTo(person2.Name.Length);
        if (compare == 0)
        {
            compare = char.ToLower(person1.Name[0]).CompareTo(char.ToLower(person2.Name[0]));
        }
        return compare;
    }
}
