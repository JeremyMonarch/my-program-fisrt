using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17.Collections
{
    public class Set<T> : ICollection<T>
    {
        private LinkedList<T>[] array;
        private int capacity;

        public Set(int capacity)
        {
            this.array = new LinkedList<T>[capacity];
            this.capacity = capacity;
        }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            if (item == null)
            {
                Console.WriteLine("Item is null");
            }
            else
            {
                var index = item.GetHashCode() % this.capacity;
                var list = this.array[index];

                if (list == null) list = new LinkedList<T>();
                list.Add(item);
                this.array[index] = list;
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            if (item == null)
            {
                Console.WriteLine("Item is null");
            }
            else
            {
                int index = item.GetHashCode();
                LinkedList<T> list = this.array[index];

                if (list == null)
                {
                    return false;
                }
                return list.Contains(item);
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
