using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mailling_List_Project.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string fullname(string FirstName, string LastName)
        {
            return FirstName + LastName;
        }
    }
}