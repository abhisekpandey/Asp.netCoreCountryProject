using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AjaxCall.DAL;
using AjaxCall.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AjaxCall.Controllers
{
    public class JvAjax : Controller
    {
        clsCuserDal cdal = new clsCuserDal();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [ActionName("List")]
        public IActionResult List()
        {
            return new JsonResult(cdal.GetUserCountry().ToList());
        }


        [HttpGet]
        [ActionName("List1")]
        public IEnumerable<CUser> List1()
        {
            List<CUser> students = new List<CUser>();
            students = cdal.GetUserCountry().ToList();
            return students;
        }

        //public IActionResult Save()
        //{
        //    return View();
        //}
        [HttpPost]
        public IActionResult Index(CUser ur)
        {
            if (ModelState.IsValid)
            {
                cdal.InsertUser(ur);
                ViewData["Message"]= " The New User Name " + ur.DESCRIPTION + " Is Saved Succesfully!";
            }
            return View(ur);
        }



    }
}
