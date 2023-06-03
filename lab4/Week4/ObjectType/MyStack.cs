/*namespace ClntSrvrWk1.Lessons.Week4.ObjectType
{
    public class MyStack
    {
        public MyStack()
        {
        }

        private const int Size = 5;
        private int position;

        private object[] items = new object[Size];

        public void Push(object obj)
        {
            items[position++] = obj;

        }

        public object Pop()
        {
            return items[--position];
        }
    }
}

*/


namespace ClntSrvrWk1.Lessons.Week4.ObjectType
{
    public class MyStack
    {
        private const int Size = 5;
        private int position;
        private object[] items = new object[Size];

        public MyStack()
        {
            position = -1; // Initialize position to -1 (empty stack)
        }

        public MyStack(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Size must be greater than zero.");
            }

            items = new object[size];
            position = -1; // Initialize position to -1 (empty stack)
        }

        public void Push(object obj)
        {
            if (position + 1 == items.Length)
            {
                throw new StackOverflowException("Stack is full. Cannot push more items.");
            }

            items[++position] = obj;
        }

        public object Pop()
        {
            if (position == -1)
            {
                throw new InvalidOperationException("Stack is empty. Cannot pop any item.");
            }

            object item = items[position];
            items[position--] = null; // Clear the reference to the popped item
            return item;
        }

        public object Peek()
        {
            if (position == -1)
            {
                throw new InvalidOperationException("Stack is empty. Cannot peek any item.");
            }

            return items[position];
        }
    }
}
