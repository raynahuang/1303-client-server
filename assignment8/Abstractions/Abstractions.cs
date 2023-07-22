using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    public interface IContact
    {
        string Id { get; }
        string Name { get; set; }
        string Address { get; set; }
        List<ContactDetail> ContactDetails { get; set; }
    }

    public class ContactDetail
    {
        public string Title { get; set; } // Title of the contact detail (e.g., "work", "home", "department", etc.)
        public string Value { get; set; } // Phone number or email address
    }

    public interface ICompany : IContact
    {
        List<IIndividual> Employees { get; set; }
    }

    public interface IIndividual : IContact
    {
        ICompany Employer { get; set; }
    }
}
