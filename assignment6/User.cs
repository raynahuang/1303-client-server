using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6
{
    //Create a base User class with Name, Username and Email address.
    public class User
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }


    //Create 2 subclass from the base: RegularUser, EliteUser
    public class RegularUser : User
    {

    }

    public class EliteUser : User
    {

    }

}
