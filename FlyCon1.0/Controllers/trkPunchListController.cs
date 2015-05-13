using FlyCon1._0.DAL;
using FlyCon1._0.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlyCon1._0.Controllers
{
    public class trkPunchListController : Controller
    {
     
        //
        // GET: /trkPunchList/

        List<trkPunchListModel> gv = new List<trkPunchListModel>();
        public ActionResult Index()
        {

            
            DataSet ds = new DataSet();
            trkPunchList punObj = new  trkPunchList();
            ds = punObj.GetPunchList();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                gv.Add(new trkPunchListModel
                {
                    ProjNo = Convert.ToString(dr["ProjNo"]),
                    IdNo = Convert.ToInt32(dr["IDNo"]),
                    LinkId = Convert.ToInt32(dr["LinkIDNo"]),
                    PunchType = Convert.ToString(dr["PunchType"]),
                    OpenBy = Convert.ToString(dr["OpenBy"]),
                    OpenDt = Convert.ToDateTime(dr["OpenDt"]),
                    EnteredBy = Convert.ToString(dr["Enteredby"]),
                    EnteredDt = Convert.ToDateTime(dr["EnteredDt"]),
                    Plant = Convert.ToString(dr["Plant"]),
                    Area = Convert.ToString(dr["Area"]),
                    Location = Convert.ToString(dr["Location"]),
                    Unit = Convert.ToString(dr["Unit"])

                });
            }
            return View(gv); 
        }

    }
}
