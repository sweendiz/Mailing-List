using System;
using Mailling_List_Project.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailingList.UnitTests
{
    [TestClass]
    public class PersonControllerTest
    {
        [TestMethod]
        public void Create_NormalUser_ReturnsTrue()
        {
          
            var person  = new Person();

            var result = person.fullname("Matt","Sweeney");

            Assert.IsNotNull(result);
        }
    }
}
