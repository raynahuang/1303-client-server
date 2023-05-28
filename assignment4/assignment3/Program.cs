
using assignment3.vehicle;
using System.Diagnostics;


namespace assignment3
{
    public class Program
    {
        static void Main(string[] args)
        {
            truck truck1 = new truck("Truck-Toyo", "Made in Jp", "RAM 1500", "Luton peak bodies", "Grey", 4, "Volvo B36", 20000,
            "VIN123456789", "ABC123", 2, 0, 130);

            Console.WriteLine("Truck introduciton");
            truck1.displayInfo();


            Car car1 = new Car("Car-BMW", "Made in USA", "CDD 233", "Touring", "White", 4, "M10", 10000,
            "VIN223456778", "GGH133", 4, 0, 160);

            Console.WriteLine("Car introduciton");
            car1.displayInfo();


            motocycle motocycle1 = new motocycle("Motocycle-Kimko", "Made in Jp", "BFF 678", "Scooter", "Black", 2, "CX 500", 4000,
            "VIN564448522", "OPR443", 0, 0, 100);

            Console.WriteLine("Motocycle introduciton");
            motocycle1.displayInfo();



            bus bus1 = new bus("Bus-Hondd", "Made in CA", "GJE 225", "Large Body Buses", "Blue", 8, "VB 1255", 40000,
            "VIN457774412", "UYY899", 5, 0, 180);

            Console.WriteLine("Bus introduciton");
            bus1.displayInfo();

        }


    }



 }
