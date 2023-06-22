using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment7
{
    /// <summary>
    /// Singly Linked List
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<T>
    {
        private int count;

        public LinkedListNode<T> Head { get; private set; }
        public LinkedListNode<T> Tail { get; private set; }

        /// <summary>
        /// Add a node to the beginning of the list
        /// </summary>
        /// <param name="node"></param>
        public void AddHead(LinkedListNode<T> node)
        {
            LinkedListNode<T> temp = this.Head;

            this.Head = node;

            this.Head.Next = temp;
            // this.count++;
        }

        /// <summary>
        /// Add a node to the end of the list
        /// </summary>
        /// <param name="node"></param>
        public void AddTail(LinkedListNode<T> node)
        {
            if (this.count == 0)
            {
                this.Head = node;
            }
            else
            {
                this.Tail.Next = node;
            }

            this.Tail = node;
            this.count++;
        }

        /// <summary>
        /// Remove the node located at the head
        /// Before: Head --> 3 --> 5
        /// After:  Head --> 5
        /// </summary>
        public void RemoveHead()
        {
            this.Head = this.Head.Next;
            this.count--;

            if (this.count == 0)
            {
                this.Tail = null;
            }
        }

        /// <summary>
        /// Remove the node located at the tail
        /// </summary>
        public void RemoveTail()
        {
            if (this.count == 0)
            {
                // The list is empty, nothing to remove
                return;
            }
            else if (this.count == 1)
            {
                // There is only one node in the list, remove it
                this.Head = null;
                this.Tail = null;
            }
            else
            {
                // Traverse the list to find the node before the tail
                LinkedListNode<T> current = this.Head;
                while (current.Next != this.Tail)
                {
                    current = current.Next;
                }

                // Update the tail node and remove the reference to it
                this.Tail = current;
                this.Tail.Next = null;
            }

            this.count--;
        }

        public bool Remove(T data)
        {
            LinkedListNode<T> current = this.Head;
            LinkedListNode<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                        {
                            this.Tail = previous;
                        }

                        this.count--;
                    }
                    else
                    {
                        this.RemoveHead();
                    }

                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }

        public int GetCount()
        {
            return this.count;
        }
    }
}
