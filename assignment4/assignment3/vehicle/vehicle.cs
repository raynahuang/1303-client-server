using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3.vehicle
{
    public class vehicle
    {
        private string brand;
        private string make;
        private string model;
        private string bodyType;
        private string color;
        private int numberOfWheels;
        private string engineType;
        private int dashboardMileage;
        private string vin;
        private string licenseNumber;
        private int numberOfDoors;
        private int speed;
        private int maxSpeed;

        public vehicle(string brand, string make, string model, string bodyType, string color, int numberOfWheels,
            string engineType, int dashboardMileage, string vin, string licenseNumber, int numberOfDoors, int speed, int maxSpeed)
        {
            this.brand = brand;
            this.make = make;
            this.model = model;
            this.bodyType = bodyType;
            this.color = color;
            this.numberOfWheels = numberOfWheels;
            this.engineType = engineType;
            this.dashboardMileage = dashboardMileage;
            this.vin = vin;
            this.licenseNumber = licenseNumber;
            this.numberOfDoors = numberOfDoors;
            this.speed = speed;
            this.maxSpeed = maxSpeed;
        }

        public string getBrand()
        {
            return brand;
        }

        public void setBrand(string value)
        {
            brand = value;
        }

        public string getMake()
        {
            return make;
        }

        public void setMake(string value)
        {
            make = value;
        }

        public string getModel()
        {
            return model;
        }

        public void setModel(string value)
        {
            model = value;
        }

        public string getBodyType()
        {
            return bodyType;
        }

        public void setBodyType(string value)
        {
            bodyType = value;
        }

        public string getColor()
        {
            return color;
        }

        public void setColor(string value)
        {
            color = value;
        }

        public int getNumberOfWheels()
        {
            return numberOfWheels;
        }

        public void setNumberOfWheels(int value)
        {
            numberOfWheels = value;
        }

        public string getEngineType()
        {
            return engineType;
        }

        public void setEngineType(string value)
        {
            engineType = value;
        }

        public int getDashboardMileage()
        {
            return dashboardMileage;
        }

        public void setDashboardMileage(int value)
        {
            dashboardMileage = value;
        }

        public string getVin()
        {
            return vin;
        }

        public void setVin(string value)
        {
            vin = value;
        }

        public string getLicenseNumber()
        {
            return licenseNumber;
        }

        public void setLicenseNumber(string value)
        {
            licenseNumber = value;
        }

        public int getNumberOfDoors()
        {
            return numberOfDoors;
        }

        public void setNumberOfDoors(int value)
        {
            numberOfDoors = value;
        }

        public int getSpeed()
        {
            return speed;
        }

        public void setSpeed(int value)
        {
            speed = value;
        }

        public int getMaxSpeed()
        {
            return maxSpeed;
        }

        public void setMaxSpeed(int value)
        {
            maxSpeed = value;
        }

        public virtual void displayInfo()
        {
            Console.WriteLine($"Brand: {getBrand()}, Make: {getMake()}, Model: {getModel()}, Body Type: {getBodyType()}, Color: {getColor()}, Number of Wheels: {getNumberOfWheels()}, "
                + $"Engine Type: {getEngineType()}, Dashboard Mileage: {getDashboardMileage()}, VIN: {getVin()}, License Numbers: {getLicenseNumber()},Number of Doors: {getNumberOfDoors()}, Speed: {getSpeed()}, Max Speed: {getMaxSpeed()} ");
            
            Console.WriteLine();
        }
    }
}
