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
using Microsoft.AspNetCore.Mvc.Rendering;
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

        [HttpPost]
        public IActionResult Index(CUser ur)
        {
            if (ModelState.IsValid)
            {
                cdal.InsertUser(ur);
                ViewData["Message"] = " The New User Name " + ur.DESCRIPTION + " Is Saved Succesfully!";
            }
            return View(ur);
        }


        [HttpGet]
        [ActionName("List")]
        public JsonResult List(int? SelectedItems)
        {
            try
                {
                    var item = cdal.GetUserCountry().ToList();
                    var items = item.ToList();
                    if (items != null)
                    {
                        List<SelectListItem> lbCountry = new List<SelectListItem>();
                        foreach (var type in items)
                        {
                            SelectListItem selecteditem = new SelectListItem()
                            {
                                Text = type.DESCRIPTION,
                                Value = type.ID.ToString()
                            };
                        lbCountry.Add(selecteditem);
                        }
                        CUser model = new CUser();
                        //model.ID = Convert.ToInt32(lbCountry);

                        return Json(items, new Newtonsoft.Json.JsonSerializerSettings());
                    }
                    else
                    {
                        return Json(null, new Newtonsoft.Json.JsonSerializerSettings());
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message.ToString());
                }            
        }


        [HttpGet]
        [ActionName("List1")]
        //[Route("~/api/List1")]
        public IEnumerable<CUser> List1()
        {
            List<CUser> students = new List<CUser>();
            students = cdal.GetUserCountry().ToList();
            return students;
            //return cdal.GetUserCountry();
        }

        [HttpGet]
        [ActionName("Details")]
        public IActionResult Details(int? ID)
        {
            if (ID == null)
            {
                return NotFound();
            }
            CUser objcu = cdal.GetBindinTable(ID);
            if (objcu == null)
            {
                return NotFound();
            }
            return new JsonResult(objcu);
        }

     
    }
}
