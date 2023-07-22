using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 Project Assignment			
	Contact Manager		
			
	Command line application in C# to manage contacts.		
	Contacts can be people, companies, ..		
			
	Operations		
	Adding and removing contacts		
	Searching by various criteria		
	Save and load from disk		
	Save and load from a remote server		
			
	Details		
	A company may have a number of contacts		
	There can be companies with no contacts 		
	There can be individuals with no company information		
	Contact details for individuals and companies are 		
	Compnay: Name, Address, Phone numbers, emails		
		Note that email and phone numbers may have a title (e.g. department) attached to it	
		As discussed company may have a number of individuals with full contact information	
	Individuals: Name, Address, Phone numbers, emails		
		Note that email and phone numbers may have a title (e.g. work, home) attached to it	
	Related contacts: Don't start until you have Part 1 and Part 2 are complated		
		Both companies and inviduals can be related to other contacts or indiduals (more on this later)	
			
Part 1	Create the projects		
	Create the models (models are the core classes and abstractions)		
			
 
 
 
 */

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
