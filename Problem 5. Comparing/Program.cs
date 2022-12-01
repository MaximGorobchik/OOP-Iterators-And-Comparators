var person = new List<Person>();
var index = new Person();
var inputline = Console.ReadLine();
while (!inputline.Equals("END"))
{
    var info = inputline.Split();
    person.Add(new Person(info[0], int.Parse(info[1]), info[2]));
    inputline= Console.ReadLine();
}
var N_Person = int.Parse(Console.ReadLine());
index.Count_People(person[N_Person - 1], person);