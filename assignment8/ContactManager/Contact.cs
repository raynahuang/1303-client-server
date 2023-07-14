using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    // Define the Contact class as the base class for both individuals and companies
    public class Contact
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<ContactNumber> PhoneNumbers { get; set; }
        public List<ContactEmail> Emails { get; set; }

        public Contact()
        {
            PhoneNumbers = new List<ContactNumber>();
            Emails = new List<ContactEmail>();
        }

        // Define the ContactNumber class to represent phone numbers with titles
        public class ContactNumber
        {
            public string Number { get; set; }
            public string Title { get; set; }
        }

        // Define the ContactEmail class to represent email addresses with titles
        public class ContactEmail
        {
            public string Email { get; set; }
            public string Title { get; set; }
        }
    }


   

}
