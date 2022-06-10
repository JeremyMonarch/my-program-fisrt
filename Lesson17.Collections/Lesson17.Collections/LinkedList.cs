using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17.Collections
{

    interface IIterator<T>
    {
        bool HasNext();
        T Current { get; }
        void Reset();
    }

    class LinkedListIterator<T> : IIterator<T>
    {
        private readonly LinkedList<T> _list;
        private int index;
        public T Current { get; private set; }
       

        public LinkedListIterator(LinkedList<T> _list)
        {
            _list = this._list;
        }
        public bool HasNext()
        {
            if (this.index <= this._list.Count)
            {
                Current = this._list.GetByIndex(this.index);
                return true;
            }
            return false;
        }

        public void Reset()
        {
           this.index = 0;
        }
    }
    public class LinkedList<T> : ICollection<T>
    {
        private class Node<T>
        {
            public Node(T value, Node<T> next)
            {
                Value = value;
                Next = next;
            }

            public T Value { get; }

            public Node<T> Next { get; set; }
        }

        private Node<T> head;
        private Node<T> tail;
        private int _count;

        public void Add(T item)
        {
            if (this.head == null)
            {
                this.head = new Node<T>(item, null);
                this.tail = this.head;
            }
            else
            {
                var newNode = new Node<T>(item, null);
                this.tail.Next = newNode;

                this.tail = newNode;
            }
            this._count++;
        }

        public IEnumerable<T> GetAll()
        {
            var item = this.head;
            while (item != null)
            {
                yield return item.Value;
                item = item.Next;
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            var pointer = this.head;
            while (pointer != null)
            {
                if(pointer.Value.Equals(item))
                {
                    return true;
                }
                pointer = pointer.Next;
            }
            return false;
        }

        public T GetByIndex(int index)
        {
            if (index < 0 || index > this._count)
            {
                throw new IndexOutOfRangeException();
            }
            var pointer = this.head;
            for (int i = 0; i < index; i++)
            {
                pointer = pointer.Next;
            }
            return pointer.Value;
        }

        // can be skipped
        public void CopyTo(T[] array, int arrayIndex)
            => throw new NotImplementedException();

        public bool Remove(T item)
            => throw new NotImplementedException();

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int Count => this._count;

        // can be skipped
        public bool IsReadOnly { get; }
    }
}
