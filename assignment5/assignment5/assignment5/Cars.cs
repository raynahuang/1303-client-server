using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    public class Car : Vehicle<VehicleType, Engine, Body>
    {
        public Car(VehicleType type, Engine engine, Body body)
            : base(type, engine, body)
        {
        }
    }
}
