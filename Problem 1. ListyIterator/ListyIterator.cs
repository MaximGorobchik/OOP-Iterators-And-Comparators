using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> list;
        private int index = 0;
        public ListyIterator()
        {
            this.list = new List<T>();
            this.index = 0;
        }
        public bool HasNext()
        {
            return this.index + 1 < this.list.Count;
        }
        public void Create(List<T> list1)
        {
            if(list1.Count == 0)
            {
                throw new Exception("Invalid Operation!");
            }
            else
            list1.ForEach(item => list.Add(item));
        }
        public bool Move()
        {
            if (HasNext())
            {
                this.index++;
                return true;
            }
            else
            return false;
        }
        public void Print()
        {
            if (list.Count == 0)
            {
                throw new Exception("List is empty");
            }
            else
            {
                Console.WriteLine(this.list[index]);
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            return this.list.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
