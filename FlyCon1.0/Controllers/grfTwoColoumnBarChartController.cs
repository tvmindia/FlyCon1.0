using MicrosoftCharts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlyCon1._0.Controllers
{
    public class grfTwoColoumnBarChartController : Controller
    {
        MicrosoftCharts.DAL.grfGraphDataAccess ChData = new MicrosoftCharts.DAL.grfGraphDataAccess();
     
        //
        // GET: /grfTwoColoumnBarChart/
        #region TwoColoumnBarChart
        public ActionResult Index()
        {
            grfGraphModel ch = new MicrosoftCharts.Models.grfGraphModel();
            //must declare IsDataTableRequired = true using model instance  
            ch.IsDataTableRequired = true;
            ch.xcolumn = "Year";
            ch.Ycolumn = "Profit";
            ch.Y2column = "Expence";
            ch.DataSourse = ChData.TwoColumnBarChartData();
            ch.CreattwoColumnChart();// generate chart                                             
            ViewBag.xaxis = ch.xData;
            ViewBag.yaxis = ch.yData;
            ViewBag.y2axis = ch.y2Data;
            return View();
            //change
        }


        /// <summary>
        /// Action used for creating TwoColoumnBarChart
        /// </summary>
        /// <returns></returns>
        public ActionResult TwoColoumnBarChart()
        {
            grfGraphModel ch = new MicrosoftCharts.Models.grfGraphModel();
            ch.xcolumn = "Year";
            ch.Ycolumn = "Profit";
            ch.Y2column = "Expence";
            ch.TableName = "ch_pai";
            // This CreattwoColumnChart() used to generate chart  
            ch.CreattwoColumnChart();
            ViewBag.xaxis = ch.xData;
            ViewBag.yaxis = ch.yData;
            ViewBag.y2axis = ch.y2Data;
            return View();
        }
        /// <summary>
        ///Action used for creating partial view of TwoColumnBarChart for declaring scripts we have used
        /// </summary>
        /// <returns></returns>
        public ActionResult TwoColumnBarChartPartial()
        {
            return PartialView("TwoColumnBarChartPartial");
        }


        #endregion TwoColoumnBarChart
    }
}
