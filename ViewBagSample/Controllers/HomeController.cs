using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBagSample.Models;
using ViewBagSample.ViewModels.Home;

namespace ViewBagSample.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index() //We'll set the ViewBag values in this action
        {
            ViewBag.PageTitle = "This is the page title";
            ViewBag.PageDescription = "This is the page description.  Hello World!";
            ViewBag.PageCreateDate = DateTime.Now;
            ViewBag.CurrentUser = new User()
            {
                Name = "Test Name",
                ID = 4,
                LogonDate = DateTime.Now.AddDays(-20)
            };
            return View();
        }

        [HttpGet]
        public ActionResult About() //This time, let's use a ViewModel
        {
            HomeAboutVM model = new HomeAboutVM();
            model.PageTitle = "This is the About page";
            model.PageDescription = "See how much better using a ViewModel is?";
            model.PageCreateDate = DateTime.Now;
            model.CurrentUser = new User()
            {
                Name = "Test Name",
                ID = 4,
                LogonDate = DateTime.Now.AddDays(-20)
            };
            return View(model);
        }
    }
}