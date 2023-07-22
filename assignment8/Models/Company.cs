using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstractions;

namespace Models
{
    public class Company : ICompany
    {
        public string Id { get; set; } // You can generate a unique ID for each company, e.g., using Guid.NewGuid().ToString()
        public string Name { get; set; }
        public string Address { get; set; }
        public List<ContactDetail> ContactDetails { get; set; } // Include ContactDetails here
        public List<ContactDetail> PhoneNumbers { get; set; }
        public List<ContactDetail> Emails { get; set; }
        public List<IIndividual> Employees { get; set; }

        public Company()
        {
            ContactDetails = new List<ContactDetail>();
            PhoneNumbers = new List<ContactDetail>();
            Emails = new List<ContactDetail>();
            Employees = new List<IIndividual>();
        }
    }
}
