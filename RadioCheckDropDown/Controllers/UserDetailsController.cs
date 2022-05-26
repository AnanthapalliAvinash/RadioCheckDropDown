using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RadioCheckDropDown.Controllers
{
    public class UserDetailsController : Controller
    {
        
        public ActionResult Index()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            // Populate from database.
            items.Add(new SelectListItem() { Text = "Test 1", Value = "1" });
            items.Add(new SelectListItem() { Text = "Test 2", Value = "2" });
            items.Add(new SelectListItem() { Text = "Test 3", Value = "3" });
            items.Add(new SelectListItem() { Text = "Test 4", Value = "4" });
            items.Add(new SelectListItem() { Text = "Test 5", Value = "5" });
            items.Add(new SelectListItem() { Text = "Test 6", Value = "6" });
            ViewData["ddl"] = items;
            return View(items);
        }
    }
}