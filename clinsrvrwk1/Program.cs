using System;

namespace ClntSrvrWk1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program was called with");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }

            Program program = new Program();
            program.PrintNumbers();

            int inches = program.FeetToInches(13);
            Console.WriteLine($"13 feet is: {inches} inches.");
            string message = "this is our first program in C#";
            var message2 = "new message";

            var arr = new int[] { 1, 2, 3, };
            bool isThisGood = true;

            // program.TestReadLine();

            // program.TestObjectAndStruct();

            // program.TestPointArray();
            program.TestMultidimensionalRectangularArray();
            program.TestMultiDimentionalJaggedArray();
        }

        public void TestObjectAndStruct()
        {
            Program program = new Program();
            var p1 = new Point();
            p1.x = 10;
            p1.y = 12;
            program.Print(p1, "p1 after assignment");

            var a = 5;
            int b = 20;
            b = a;         // copies the actual value from a to b 

            Point p2 = p1; // copies the reference from p1 into p2
            program.Print(p2, "p2 after assignment");

            Point p3 = new Point();
            p3.x = 23;
            p3.y = 64;

            program.Print(p3, "p3 before assignment");
            p3 = p1;
            program.Print(p3, "p3 after assignment");

            Point p4 = new Point();

            p4 = null;
            program.Print(p4, "p4 assignment");
            if (p4 == null)
            {
                Console.WriteLine("p4 is null");
            }

            PointStruct ps1 = new PointStruct();
            ps1.x = 10;
            ps1.y = 15;

            PointStruct ps2;
        }

        public void Print(Point p, string message)
        {
            if (p == null)
            {
                Console.WriteLine("Point refers to a null!");
                return;
            }
            Console.WriteLine($"{message}: x:{p.x} y:{p.y}");
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

        public void TestReadLine()
        {
            Console.WriteLine("Enter one or more lines - press CTRL+Z followed by Enter to exit):");
            string line;

            do
            {
                Console.Write(" ==> ");
                line = Console.ReadLine();
                if (line != null)
                {
                    Console.WriteLine($" {line}");
                }

            } while (line != null);
        }

        public void TestCharArray()
        {
            char[] vowels = new char[5];
            vowels[0] = 'a';
            vowels[1] = 'e';
            vowels[2] = 'i';
            vowels[3] = 'o';
            vowels[4] = 'u';

            char[] vowels2 = new char[] { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < vowels2.Length; i++)
            {
                Console.Write($"{vowels2[i]} ");
            }
        }

        public void TestPointArray()
        {
            // Point[] pointArray = new Point[3];
            var pointArray = new Point[3];

            for (int i = 0; i < pointArray.Length; i++)
            {
                pointArray[i] = new Point()
                {
                    x = i,
                    y = i * 2
                };
            }
        }

        /// <summary>
        /// create a 2 dimensional rectangular array
        /// {0,1,2}
        /// {3,4,5}
        /// {6,7,8}
        /// </summary>
        public void TestMultidimensionalRectangularArray()
        {
            Console.WriteLine("Rectangular array example:");
            int[,] matrix = new int[3, 3];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = (i * 3) + j;
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public void TestMultiDimentionalJaggedArray()
        {
            int[][] matrix = new int[3][];

            Console.WriteLine("Jagged array example:");
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[3];
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = (i * 3) + j;
                    Console.Write($"{matrix[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
