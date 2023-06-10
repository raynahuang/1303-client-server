using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    //Define the VehicleType enum
    public enum VehicleType
    {
        Car,
        Truck,
        Bus,
        Motorcycle
    }

    //Create two new classes for Engine and Body.
    public class Engine
    {
        public string Manufacturer { get; set; }
        public double Horsepower { get; set; }

        public Engine(string manufacturer, double horsepower)
        {
            Manufacturer = manufacturer;
            Horsepower = horsepower;
        }

        public override string ToString()
        {
            return $"{Manufacturer} Engine ({Horsepower} HP)";
        }
    }

    public class Body
    {
        public string Color { get; set; }
        public int Doors { get; set; }

        public Body(string color, int doors)
        {
            Color = color;
            Doors = doors;
        }

        public override string ToString()
        {
            return $"{Color} Body ({Doors} doors)";
        }
    }


    //Create a new generic Vehicle class that accepts three generic type parameters for VehicleType, Engine, Body.
    public class Vehicle<TVehicleType, TEngine, TBody>
    where TVehicleType : Enum
    where TEngine : Engine
    where TBody : Body
    {
        public TVehicleType Type { get; set; }
        public TEngine Engine { get; set; }
        public TBody Body { get; set; }

        public Vehicle(TVehicleType type, TEngine engine, TBody body)
        {
            Type = type;
            Engine = engine;
            Body = body;
        }

        public override string ToString()
        {
            return $"{Type}: {Engine}, {Body}";
        }
    }



}
