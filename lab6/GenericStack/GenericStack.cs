using System;
using System.Collections.Generic;
using System.Threading;

namespace GenericStack
{
    public class GenericStack<T>
    {
        private readonly int _size;
        private volatile int _position;
        private readonly T[] _data;

        public GenericStack(int size)
        {
            if (size <= 0)
                throw new ArgumentException("Size must be greater than zero.");

            _size = size;
            _data = new T[_size];
            _position = -1;
        }

        public void Push(T item)
        {
            int newPosition = Interlocked.Increment(ref _position);
            if (newPosition >= _size)
            {
                Interlocked.Decrement(ref _position);
                throw new InvalidOperationException("Stack is full.");
            }

            _data[newPosition] = item;
        }

        public T Pop()
        {
            int currentPosition = Interlocked.Decrement(ref _position);
            if (currentPosition < 0)
            {
                Interlocked.Increment(ref _position);
                throw new InvalidOperationException("Stack is empty.");
            }

            return _data[currentPosition + 1];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var stack = new GenericStack<int>(3);

                stack.Push(1);
                stack.Push(2);
                stack.Push(3);

                var poppedItems = new List<int>();
                while (true)
                {
                    try
                    {
                        var item = stack.Pop();
                        poppedItems.Add(item);
                    }
                    catch (InvalidOperationException)
                    {
                        break; // Exit the loop when the stack is empty
                    }
                }

                // Display the popped items in the original order
                poppedItems.Reverse(); // Reverse the list to get the original order
                foreach (var item in poppedItems)
                {
                    Console.WriteLine(item);
                }

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }
    }
}
