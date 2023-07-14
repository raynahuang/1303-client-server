using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    internal class Company : Contact
    {
        public List<Individual> Contacts { get; set; }

        public Company()
        {
            Contacts = new List<Individual>();
        }
    }
}
