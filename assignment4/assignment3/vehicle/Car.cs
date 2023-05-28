using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3.vehicle
{
    public class Car : vehicle
    {
        public Car(string brand, string make, string model, string bodyType, string color, int numberOfWheels,
            string engineType, int dashboardMileage, string vin, string licenseNumber, int numberOfDoors, int speed, int maxSpeed)
            : base(brand, make, model, bodyType, color, numberOfWheels, engineType, dashboardMileage, vin, licenseNumber,
                numberOfDoors, speed, maxSpeed)
        {
        }

        public override void displayInfo()
        {
            base.displayInfo();
        }
    }
}
