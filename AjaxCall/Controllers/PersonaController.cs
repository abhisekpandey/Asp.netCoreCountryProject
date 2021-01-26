using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AjaxCall.Models;
using AjaxCall.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AjaxCall.Controllers
{
    public class PersonaController : Controller
    {
        public IActionResult Index()
        {
            Person person = new Person()
            {
                PersonID = 101,
                Name = "Dillip",
                Age = 20,
                Salary = 25000
               
            };
            //Student Address
            Address address = new Address()
            {
                PersonID = 101,
                State = "Maharashtra",
                Country = "India",
            };
            //Creating the View model
            VMPracticeViewModel vm = new VMPracticeViewModel()
            {
                Person = person,
                Address = address,
                Title = "Person Details Page",
                Header = "Person Details",
            };
            return View(vm);
        }

    }
}
