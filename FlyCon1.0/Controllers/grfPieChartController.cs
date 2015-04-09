using MicrosoftCharts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MicrosoftCharts.DAL;
namespace FlyCon1._0.Controllers
{
    public class grfPieChartController : Controller
    {
        //
        // GET: /grfPieChart/
        MicrosoftCharts.DAL.grfGraphDataAccess ChData = new MicrosoftCharts.DAL.grfGraphDataAccess();
        #region PieChart
        /// <summary>
        ///  Action used for creating PieChart using datasource
        /// </summary>
        /// <returns></returns>
        
        public ActionResult Index()
        {
            grfGraphModel chPie = new MicrosoftCharts.Models.grfGraphModel();
            //must declare IsDataTableRequired = true using model instance
            chPie.IsDataTableRequired = true;
            chPie.xcolumn = "Year";
            chPie.Ycolumn = "Profit";
            chPie.DataSourse = ChData.BindPieChartData();// bind data  
            chPie.CreateChart();// generate chart
            ViewBag.xaxis = chPie.xData;
            ViewBag.yaxis = chPie.yData;


            return View();
        }


        /// <summary>
        ///  Action used for creating PieChart using datasource
        /// </summary>
        /// <returns></returns>
        

        public ActionResult PieChart()
        {
            grfGraphModel chPie = new MicrosoftCharts.Models.grfGraphModel();
            //must declare IsDataTableRequired = true using model instance
            chPie.IsDataTableRequired = true;
            chPie.xcolumn = "Year";
            chPie.Ycolumn = "Profit";
            chPie.DataSourse = ChData.BindPieChartData();// bind data  
            chPie.CreateChart();// generate chart
            ViewBag.xaxis = chPie.xData;
            ViewBag.yaxis = chPie.yData;


            return View();
        }


        /// <summary>
        /// Action used for creating partial view of PieChart for declaring scripts we have used
        /// </summary>
        /// <returns></returns>
        public ActionResult PieChartPartial()
        {
            return PartialView("PieChartPartial");
        }
        #endregion PieChart
       
    

    }
}
