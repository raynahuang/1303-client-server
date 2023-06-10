using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    public class Buses : Vehicle<VehicleType, Engine, Body>
    {
        public Buses(VehicleType type, Engine engine, Body body)
            : base(type, engine, body)
        {
        }
    }
}
