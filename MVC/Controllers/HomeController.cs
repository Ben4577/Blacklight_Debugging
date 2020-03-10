using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlackLight.Recruitment.MVC.Models;

namespace BlackLight.Recruitment.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View(new ContactUsViewModel());
        }

        [HttpPost]
        public ActionResult ContactUsSubmit(ContactUsViewModel form)
        {
            if (!ModelState.IsValid)
            {
                return View("Contact", form);
            }
            
            return RedirectToAction("Thanks", new {name = form.Name});
        }

        public ActionResult Thanks(string name)
        {
            var model = new ThanksViewModel
            {
                Name = name,
                CorrectName = name == "Thorin Oakenshield son of Thrain" ? true : false
            };

            return View(model);
        }
	}
}