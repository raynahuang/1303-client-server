using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Abstractions;

namespace Models
{
    public class Individual : Iindividual
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<ContactDetail> ContactDetails { get; set; }
        public List<ContactDetail> PhoneNumbers { get; set; }
        public List<ContactDetail> Emails { get; set; }
        public Icompany Employer { get; set; }

        public Individual()
        {
            ContactDetails = new List<ContactDetail>();
            PhoneNumbers = new List<ContactDetail>();
            Emails = new List<ContactDetail>();
        }
    }
}
