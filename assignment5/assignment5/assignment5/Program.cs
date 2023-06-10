using System;
using assignment5;

namespace assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intStack = new MyStack<int>();
            var stringStack = new MyStack<string>();
            var doubleStack = new MyStack<double>();

            // Push items onto the stacks
            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);

            stringStack.Push("Hello");
            stringStack.Push("World");
            stringStack.Push("!");

            doubleStack.Push(3.14);
            doubleStack.Push(2.718);

            // Pop items from the stacks
            int poppedInt = intStack.Pop();
            string poppedString = stringStack.Pop();

            Console.WriteLine("Popped integer: " + poppedInt);
            Console.WriteLine("Popped string: " + poppedString);

            // Display the current state of the stacks
            DisplayStackContents(intStack, "Int stack:");
            DisplayStackContents(stringStack, "String stack:");
            DisplayStackContents(doubleStack, "Double stack:");


            static void DisplayStackContents<T>(MyStack<T> stack, string title)
            {
                Console.WriteLine(title);
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine();

            // Create a Car object
            var car = new Car(VehicleType.Car, new Engine("Manufacturer X", 200), new Body("Black", 4));

            // Access and display the car details
            Console.WriteLine(car);

            // Create a Buses object
            var bus = new Buses(VehicleType.Bus, new Engine("Manufacturer Y", 300), new Body("Navy", 2));

            // Access and display the bus details
            Console.WriteLine(bus);


            // Create a Motorcycles object
            var motorcycle = new Motorcycles(VehicleType.Motorcycle, new Engine("Manufacturer Z", 100), new Body("Yellow", 0));

            // Access and display the motorcycle details
            Console.WriteLine(motorcycle);

            // Create a Truck object
            var truck = new Truck(VehicleType.Truck, new Engine("Manufacturer A", 200), new Body("Red", 2));

            // Access and display the truck details
            Console.WriteLine(truck);

        }

        

        
    }
}
