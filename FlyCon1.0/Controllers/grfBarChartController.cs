using MicrosoftCharts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlyCon1._0.Controllers
{
    public class grfBarChartController : Controller
    {
        //
        // GET: /grfBarChart/
        MicrosoftCharts.DAL.grfGraphDataAccess ChData = new MicrosoftCharts.DAL.grfGraphDataAccess();

        #region barchart

        /// <summary>
        ///  Action used for creating barchart using datasource
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {

            grfGraphModel cm = new grfGraphModel();
            grfGraphModel cm1 = new grfGraphModel();
            cm.IsDataTableRequired = true; // in this case we must declare IsDataTableRequired=true using model instance                    
            cm.xcolumn = "Name";
            cm.Ycolumn = "Price";
            cm.DataSourse = ChData.BindChartData();
            cm.CreateChart();    // generate graph                           
            ViewBag.xaxis = cm.xData;
            ViewBag.yaxis = cm.yData;
            cm1.IsDataTableRequired = true;
            cm1.xcolumn = "Name";
            cm1.Ycolumn = "Price";
            cm1.DataSourse = ChData.BindChartData();
            cm1.CreateChart();
            ViewBag.Xaxis = cm.xData;
            ViewBag.Yaxis = cm.yData;
            return View();
        }

        /// <summary>
        ///  Action used for creating barchart using tablename
        /// </summary>
        /// <returns></returns>
        public ActionResult Barchart()
        {
            grfGraphModel ch = new MicrosoftCharts.Models.grfGraphModel();
            ch.xcolumn = "Name";
            ch.Ycolumn = "Price";
            ch.TableName = "chart";
            // This method used to generate chart                                
            ch.CreateChart();
            ViewBag.xaxis = ch.xData;
            ViewBag.yaxis = ch.yData;
            return View();
        }
        /// <summary>
        ///  Action used for creating partial view of BarChart for declaring scripts we have used
        /// </summary>
        /// <returns></returns>
        public ActionResult BarChartPartial()
        {
            return PartialView("BarChartPartial");
        }

        #endregion barchart

    }
}
