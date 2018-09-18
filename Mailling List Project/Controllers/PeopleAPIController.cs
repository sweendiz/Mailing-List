using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;
using Mailling_List_Project.Models;

namespace Mailling_List_Project.Controllers.API
{
    public class PeopleAPIController : ApiController
    {
        /*
         Pulling informatoin from a db... Having issues pulling info from session

             */

        /*
         * private ApplicationDbContext _contxt;
         * public PeopleAPIController();
         * {
         *      _context = new AplicatoinDbContext();
         * }
         * public IEnumerable<Person> GetPerson()
         * {
         *   return _context.People.ToList();
         * }
             */
        List<Person> people = new List<Person>();
        public PeopleAPIController()
        {
            people.Add(new Person { FirstName = "Matt", LastName = "Sweeney", Email = "Matt.Sweeney371@gmail.com" });
            people.Add(new Person { FirstName = "steveatt", LastName = "Sweeney", Email = "Matt.Sweeney371@gmail.com" });
            people.Add(new Person { FirstName = "Paul", LastName = "Blart", Email = "pb42@gmail.com" });
            people.Add(new Person { FirstName = "gandalf", LastName = "Mithrandir", Email = "TheWhite@gmail.com" });
            people.Add(new Person { FirstName = "Aatt", LastName = "Sweeney", Email = "Matt.Sweeney371@gmail.com" });
            people.Add(new Person { FirstName = "Datt", LastName = "Sweeney", Email = "Matt.Sweeney371@gmail.com" });
            people.Add(new Person { FirstName = "Batt", LastName = "Sweeney", Email = "Matt.Sweeney371@gmail.com" });
        }

        public List<Person> Get(string id)
        {
            List<Person> temp = people.OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();

            if (id == "1")
            {
                temp.Reverse();
            }
            return temp;
        }
        public List<Person> Get()
        {
            return people.OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();
        }
     
    }
}
