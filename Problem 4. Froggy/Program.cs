var inputline = Console.ReadLine().Split().Select(int.Parse);
var number_of_stones = new Lake(inputline.ToList());
Console.WriteLine($"{string.Join(",", number_of_stones)}");
