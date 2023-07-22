using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstractions;


namespace Models
{

    public class Contact : IContact
    {
        public string Id { get; set; } // You can generate a unique ID for each contact, e.g., using Guid.NewGuid().ToString()
        public string Name { get; set; }
        public string Address { get; set; }
        public List<ContactDetail> ContactDetails { get; set; }
    }
}
