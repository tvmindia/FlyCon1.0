using FlyCon1._0.DAL;
using FlyCon1._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlyCon1._0.Controllers
{
    public class trkActivityDetailsController : Controller
    {
        //
        // GET: /trkActivityDetails/

        public ActionResult Index(trkActivityDetailsModel model)
        {
            trkActivityDetails activityObj=new trkActivityDetails();
            model.TagId = 1;
            model.ActivityId = 1;
            model.ds = activityObj.GetActivityDetailsByActivityIdAndTagId(model.TagId,model.ActivityId);          
            return View(model);
        }
        public ActionResult MouseHover(trkActivityDetailsModel model)
        {
            trkActivityDetails activityObj = new trkActivityDetails();
            model.CompletedById=1;
           
            model.ds = activityObj.GetUderDetailsByUserId(model, model.CompletedById);
            return View(model);
        }

        public ActionResult test(trkActivityDetailsModel model)
        {
            return View(model);
        }


    }
}
