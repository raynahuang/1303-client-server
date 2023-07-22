using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstractions;

namespace Models
{
    public class Individual : IIndividual
    {
        public string Id { get; set; } // You can generate a unique ID for each individual, e.g., using Guid.NewGuid().ToString()
        public string Name { get; set; }
        public string Address { get; set; }
        public List<ContactDetail> ContactDetails { get; set; } // Include ContactDetails here
        public List<ContactDetail> PhoneNumbers { get; set; }
        public List<ContactDetail> Emails { get; set; }
        public ICompany Employer { get; set; }

        public Individual()
        {
            ContactDetails = new List<ContactDetail>();
            PhoneNumbers = new List<ContactDetail>();
            Emails = new List<ContactDetail>();
        }
    }
}
