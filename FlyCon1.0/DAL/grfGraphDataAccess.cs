using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MicrosoftCharts.DAL
{
    public class grfGraphDataAccess
    {

        #region BindChartData

        /// <summary>
        /// get barchart data
        /// </summary>
        /// <returns>return datatable</returns>

        public DataTable BindChartData()
        {
            SqlConnection con = null;
            DataSet dataset = null;
            try
            {


                con = Connection.GetConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("PROC_GETCHARTNAMEPRICE", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                dataset = new DataSet();
                adapter.Fill(dataset);
                DataTable Table = dataset.Tables[0];

                return Table;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }

        }

        #endregion BindChartData

        #region BindPieChartData

        /// <summary>
        /// get Piechart data
        /// </summary>
        /// <returns>return datatable</returns>
        public DataTable BindPieChartData()
        {
            SqlConnection con = null;
            DataSet dataset = null;
            try
            {


                con = Connection.GetConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("PROC_GETCHARTDATA", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                dataset = new DataSet();
                adapter.Fill(dataset);
                DataTable Table = dataset.Tables[0];

                return Table;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }

        }

        #endregion BindPieChartData

        #region TwoColumnBarChartData

        /// <summary>
        /// get TwoColumnBarChart data
        /// </summary>
        /// <returns>return datatable</returns>
        public DataTable TwoColumnBarChartData()
        {
            SqlConnection con = null;
            DataSet dataset = null;
            try
            {


                con = Connection.GetConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("PROC_GETDATA", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                dataset = new DataSet();
                adapter.Fill(dataset);
                DataTable Table = dataset.Tables[0];

                return Table;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }

        }

        #endregion TwoColumnBarChartData

        #region GetDataTable
        /// <summary>
        /// get data if we pass tablename and coloumns
        /// </summary>
        /// <param name="ColumnNames"></param>
        /// <param name="TableName"></param>
        /// <returns>return datatable</returns>

        public DataTable GetDataTable(string ColumnNames, string TableName)
        {
            ////TwoStringValue tsv;
            string FieldValue = "";

            SqlConnection con = null;
            DataSet dataset = null;
            try
            {


                con = Connection.GetConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_SelecChartData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TableName", TableName);
                cmd.Parameters.AddWithValue("@p_selectedFields", ColumnNames);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                dataset = new DataSet();
                adapter.Fill(dataset);
                DataTable Table = dataset.Tables[0];

                return Table;

                //return (Y);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }

        }

        #endregion GetDataTable
    }
}