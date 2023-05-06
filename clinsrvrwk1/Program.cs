using System;
using System.Net.Http.Headers;

namespace clinsrvrwk1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program was called with what ");
            for(int i=0; i < args.Length ; i++)
            {
                Console.WriteLine(args[i]);
            }

            Program program = new Program();
            program.PrintNumbers();


            int inches =program.FeetToInches(13);
            Console.WriteLine($"14 feet is: {inches} inches.");
            string message = "this is our first program in C#";
            var message2 = "new message";

       
            var arr = new int[] { 1, 2, 3, };
            bool isThisGood = true;

            var p1 = new Point();
            p1.x = 10;
            p1.y = 12;

            var a = 5;
            int b = 20;
            b = a;          //copies the actual value from a to b


            Point p2 = p1; //copies the reference from p1 into p2

        }


        public void PrintNumbers()
            {
                Console.WriteLine("this is a test");

                for (int i = 0; i < 1000; i++)
                {
                    Console.Write(" ");
                    Console.Write(i);
                }
                Console.WriteLine("end of loop");


            }

        public int FeetToInches(int feet)
        {
            int inches = feet * 12;

            return inches;
        }
        
    }
}
