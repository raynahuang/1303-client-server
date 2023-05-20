using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3.vehicle
{
    public class vehicle
    {
        private int id;
        private string name;

        public vehicle(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int getId() 
        { 
            return this.id; 
        }
        public string getName()
        {
            return this.name;
        }
    }

}
