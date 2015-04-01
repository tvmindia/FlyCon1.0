using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MicrosoftCharts.Models;

namespace MicrosoftCharts.Controllers
{
    public class GraphController : Controller
    {
        DAL.ChartData ChData = new DAL.ChartData();

        #region barchart

        /// <summary>
        ///  Action used for creating barchart
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()                             
        {

            ChartModel cm = new ChartModel();
            ChartModel cm1 = new ChartModel();
           

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
        ///  Action used for creating partial view of BarChart for declaring scripts we have used
        /// </summary>
        /// <returns></returns>
        public ActionResult BarChartPartial()
        {
            return PartialView("BarChartPartial");
        }

        #endregion barchart

        #region PieChart
        /// <summary>
        ///  Action for creating PieChart
        /// </summary>
        /// <returns></returns>
        public ActionResult Pie()                         
        {
            ChartModel chPie = new Models.ChartModel();
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

        #region TwoColoumnBarChart
        /// <summary>
        /// Action used for creating TwoColoumnBarChart
        /// </summary>
        /// <returns></returns>
        public ActionResult TwoColoumnBarChart()                                          
        {

            ChartModel ch = new Models.ChartModel();
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
