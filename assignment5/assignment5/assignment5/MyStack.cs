using System;
using System.Collections;
using System.Collections.Generic;

namespace assignment5
{
    internal class MyStack<T> : IEnumerable<T>
    {
        private List<T> items;

        public MyStack()
        {
            items = new List<T>();
        }

        public void Push(T obj)
        {
            items.Add(obj);
        }

        public T Pop()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty. Cannot pop any item.");
            }

            int lastIndex = items.Count - 1;
            T item = items[lastIndex];
            items.RemoveAt(lastIndex);
            return item;
        }

        public T Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty. Cannot peek any item.");
            }

            return items[items.Count - 1];
        }

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
