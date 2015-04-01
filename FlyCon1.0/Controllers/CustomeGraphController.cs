using MicrosoftCharts.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MicrosoftCharts.Controllers
{
    public class CustomeGraphController : Controller
    {
        //
        // GET: /MSChartArray/

        #region barchart
        /// <summary>
        /// Action used for creating barchart
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()                                                     
        {
                ChartModel ch = new Models.ChartModel();                                             
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
        ///  Action used for creating partial view of barchart for declaring scripts we have used
        /// </summary>
        /// <returns></returns>
        public ActionResult BarChartPartial() 
        {
            return PartialView("BarChartPartial");
        }
        #endregion barchart

        #region PieChart
        /// <summary>
        ///  Action used for creating PieChart
        /// </summary>
        /// <returns></returns>
        public ActionResult Pie()                                               
        {
            ChartModel chPie = new Models.ChartModel();
            chPie.xcolumn = "Year";
            chPie.Ycolumn = "Profit";
            chPie.TableName = "ch_pai";
           // This CreateChart() used to generate chart                            
            chPie.CreateChart();                                              
            ViewBag.xaxis = chPie.xData;                                    
            ViewBag.yaxis = chPie.yData;                                   
          
      
                return View();
        }


        /// <summary>
        ///  Action used for creating partial view of  PieChart for declaring scripts we have used
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
