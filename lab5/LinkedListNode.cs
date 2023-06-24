using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class LinkedListNode<T>
    {
        public T Data { get; set; }

        public LinkedListNode(T data)
        {
            this.Data = data;
        }

        public LinkedListNode<T> Next { get; set; }
    }
}
