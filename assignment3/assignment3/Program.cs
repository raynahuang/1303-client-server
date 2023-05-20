
using assignment3.vehicle;


namespace assignment3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bus1 = new bus(111, "Big Boss");
            Console.WriteLine ($"Bus ID:  {bus1.getId()}, Bus Name: {bus1.getName()}");

            var Car1 = new Car(222, "BMW");
            Console.WriteLine ($"Car ID:  {Car1.getId()}, Car Name: {Car1.getName()}");

            var motocycle1 = new motocycle(333, "Yamaha");
            Console.WriteLine ($"Motocycle ID:  {motocycle1.getId()}, Motocycle Name: {motocycle1.getName()}");

            var truck1 = new truck(444, "Toyota");
            Console.WriteLine ($"Truck ID:  {truck1.getId()}, Truck Name: {truck1.getName()}");

        }



    }
}