using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using MicrosoftCharts.DAL;
using FlyCon1._0.Models;

namespace FlyCon1._0.DAL
{
    public class trkPunchList
    {
     public DataSet GetPunchList()
        {
            DataSet ds = new DataSet();
            SqlConnection conObj = null;
            SqlDataAdapter daObj;
            try
            {
                
                conObj = Connection.GetConnection();
                conObj.Open();

                string selectQuery = "select ProjNo,IDNo,LinkIDNo,PunchType,OpenBy,OpenDt,EnteredBy,EnteredDt,Plant,Area,Location,Unit from PunchItems";
                daObj = new SqlDataAdapter(selectQuery, conObj);
                daObj.Fill(ds);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conObj.Close();
            }
            
           return ds;
        }

        public bool AddtoPunchList(trkPunchListModel pl)
        {
            bool result;
            SqlConnection conObj = null;
            try
            {
                conObj = Connection.GetConnection();
                conObj.Open();

                string insertQuery = "procPunchItemsInsert";
                SqlCommand cmdInsert = new SqlCommand(insertQuery, conObj);
                cmdInsert.CommandType = CommandType.StoredProcedure;
                cmdInsert.Parameters.AddWithValue("@projectno", pl.ProjNo);
                cmdInsert.Parameters.AddWithValue("@Idno", pl.IdNo);
                cmdInsert.Parameters.AddWithValue("@linkid", pl.LinkId);
                cmdInsert.Parameters.AddWithValue("@punchtype", pl.PunchType);
                cmdInsert.Parameters.AddWithValue("@openby", pl.OpenBy);
                cmdInsert.Parameters.AddWithValue("@opendate", pl.OpenDt);
                cmdInsert.Parameters.AddWithValue("@Enteredby", pl.EnteredBy);
                cmdInsert.Parameters.AddWithValue("@Entereddt ", pl.EnteredDt);
                cmdInsert.Parameters.AddWithValue("@plant", pl.Plant);
                cmdInsert.Parameters.AddWithValue("@area", pl.Area);
                cmdInsert.Parameters.AddWithValue("@location", pl.Location);
                cmdInsert.Parameters.AddWithValue("@unit", pl.Unit);
                result = Convert.ToBoolean(cmdInsert.ExecuteNonQuery());

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conObj.Close();
            }
            return result;

        }
      
        }
    }
