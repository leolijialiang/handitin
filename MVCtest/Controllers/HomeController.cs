using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCtest.Models;

namespace MVCtest.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greetings = hour < 12 ? "good morning" : "good afternood";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if(ModelState.IsValid){
                return View("Thanks", guestResponse);
            }else{
                return View();
            }
                       
        }


    }
}
