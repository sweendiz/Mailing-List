using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mailling_List_Project.Models;

namespace Mailling_List_Project.Controllers
{
    public class PeopleController : Controller
    {
        List<Person> _data = new List<Person>();

        public ActionResult New() {
            return View();
        }
        [HttpPost]
        public ActionResult Create( Person person)   
        {

            string First = person.FirstName;
            string Last = person.LastName;
            string Email = person.Email;

            var temp = (Session["people"] as List<Person>) ?? new List<Person>();
            temp.Add(person);
            Session["people"] = temp;

            //I would just add to db here... 


           
            return View();
            
        }
        public ActionResult All()
        {
            return View();
        }
        public ActionResult Index()
        {
            List<Person> PeopleList = new List<Person>();
            return View();
        }
    }
}