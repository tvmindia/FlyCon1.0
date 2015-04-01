using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MicrosoftCharts.Models
{
    public class ChartModel
    {
        #region Properties
        public DataTable DataSourse
        {
            get;
            set;
        }
        public string xcolumn
        {
            get;
            set;
        }
        public string xData
        {
            get;
            set;
        }
        public string yData
        {
            get;
            set;
        }
        public string y2Data
        {
            get;
            set;
        }
        public string Ycolumn
        {
            get;
            set;
        }

       
        public string Y2column
        {
            get;
            set;
        }
        public string TableName
        {
            get;
            set;
        }

        public bool IsDataTableRequired
        {
            get;
            set;
        }

        public object xViewBag;

        #endregion Properties


        #region GetChartData
        public string XAxisdata()
        {
            string X = "";
            string Xaxis = "";
            for (int i = 0; i < DataSourse.Rows.Count; i++)
            {

                X = X + ',' + DataSourse.Rows[i][xcolumn].ToString();

            }
            Xaxis = X.TrimStart(',');
            

            return (Xaxis);
        }
        public string YAxisdata()
        {
            string Y = "";
            string Yaxis = "";
            for (int i = 0; i < DataSourse.Rows.Count; i++)
            {
                Y = Y + "," + DataSourse.Rows[i][Ycolumn].ToString();

            }
            //return (X);
            Yaxis = Y.TrimStart(',');

            return (Yaxis);
        }

  
        public void CreateChart()
        {
            try
            {



                DAL.ChartData cdata = new DAL.ChartData();


                if (IsDataTableRequired == false)
                {

                    DataSourse = cdata.GetDataTable(xcolumn + "," + Ycolumn, TableName);

                }

                if (DataSourse == null)
                {
                    throw new Exception("DataSourse is missing");
                }


                xData = XAxisdata();// return this data to controller
                yData = YAxisdata();// return this data to controller
             



            }
            catch(Exception ex)
            {
                throw ex;
            }


        }

        #endregion GetChartData

        #region GetTwoColumnChartData
        public void CreattwoColumnChart()
        {
            try
            {



                DAL.ChartData cdata = new DAL.ChartData();


                if (IsDataTableRequired == false)
                {

                    DataSourse = cdata.GetDataTable(xcolumn + "," + Ycolumn + "," + Y2column, TableName);

                }

                if (DataSourse == null)
                {
                    throw new Exception("DataSourse is missing");
                }


                xData = XAxisdata();
                yData = YAxisdata();
                y2Data = Y2Axisdata();


            }
            catch(Exception ex)
            {
                throw ex;
            }


        }
            public string Y2Axisdata()
            {
                string Y2 = "";
                string Y2axis = "";
                for (int i = 0; i < DataSourse.Rows.Count; i++)
                {
                    Y2 = Y2 + "," + DataSourse.Rows[i][Y2column].ToString();

                }
                //return (X);
                Y2axis = Y2.TrimStart(',');

                return (Y2axis);
            }
        #endregion GetTwoColumnChartData
    }
    

}