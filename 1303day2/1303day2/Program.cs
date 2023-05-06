namespace _1303day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.TestReadLine();


        }

        public void TestReadLine()
        {
            Console.WriteLine("enter one or more lines -press ctrl+z to exit):");
            string line;

            do
            {
                Console.Write(" ==> ");
                line = Console.ReadLine();
                if (line != null)
                {
                    Console.WriteLine($"{line}");
                }
            } while (line != null);
        }
    }
}