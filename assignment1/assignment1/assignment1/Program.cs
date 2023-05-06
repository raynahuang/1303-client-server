using System;

namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = GetUserChoice();
            Console.WriteLine($"You selected option {choice}.");
        }

        public static int GetUserChoice()
        {
            int choice;

            do
            {
                Console.WriteLine("Please select an option:");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{i} - Option {i}");
                }

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");
                    continue;
                }

                if (choice < 1 || choice > 10)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");
                    continue;
                }

                Console.WriteLine($"You selected Option {choice}");
                break;

            } while (true);

            return choice;
        }
    }
}
