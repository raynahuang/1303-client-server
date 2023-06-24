namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddTail(new LinkedListNode<int>(56));
            list.AddTail(new LinkedListNode<int>(24));
            list.AddTail(new LinkedListNode<int>(101));

            Console.WriteLine("Original List:");
            list.Display();

            list.Reverse();

            Console.WriteLine("Reversed List:");
            list.Display();
        }
    }
}