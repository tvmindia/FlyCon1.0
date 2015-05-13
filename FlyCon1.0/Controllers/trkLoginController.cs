using FlyCon1._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlyCon1._0.Controllers
{
    public class trkLoginController : Controller
    {
        //
        // GET: /trkLogin/

        public ActionResult Index()
        {
            return View();
        }

          //[HttpPost]
        public ActionResult Login()
        {
            trkLoginModel trl=new trkLoginModel();
            if (ModelState.IsValid)
            {
                var profileData = new trkLoginModel
                {
                    UserName = "Amrutha",
                    ProjNo = "CCMS001",
                    ProjPreference = ""
                };
                //trl.UserName = Request.Form["Username"];

                this.Session["UserProfile"] = profileData;
             
            }
           
                return RedirectToAction("MainPage");
            
        }

          public ActionResult MainPage()
          {


              return View();

          }
          public ActionResult MainPageIcons()
          {
              return View();
          }
   
    }
}
