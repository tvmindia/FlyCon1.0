using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MicrosoftCharts.DAL
{
    public class Connection
    {
        #region GetConnection
        public static SqlConnection GetConnection()
        {

            String strcon = ConfigurationManager.ConnectionStrings["dbCon"].ToString();
            SqlConnection con = new SqlConnection(strcon);
            return con;
        }
        #endregion GetConnection
    }
}