using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.ListyIterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try {
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
                    inputline = Console.ReadLine();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
