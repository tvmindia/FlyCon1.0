using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MicrosoftCharts.DAL;
using FlyCon1._0.Models;


namespace FlyCon1._0.DAL
{
    public class trkActivityDetails
    {
        public DataSet GetActivityDetailsByActivityIdAndTagId(int activityId,int tagId)
        {
            DataSet ds = new DataSet();
            SqlConnection conObj = null;
            SqlDataAdapter daObj;

            try
            {
                conObj = Connection.GetConnection();
                conObj.Open();

                string selectQuery = "select det_id,det_description,det_startdate,det_enddate,user_name,det_status,det_budget,det_rate,det_ratenorm  from  dummyActivityDetail join MASTER_UserDetails on user_id=det_completedby where det_tagid=@tagid and det_actid=@actid and user_id=1";
                SqlCommand cmdSelect = new SqlCommand(selectQuery, conObj);
                cmdSelect.Parameters.AddWithValue("@tagid", tagId);
                cmdSelect.Parameters.AddWithValue("@actid", activityId);
                daObj = new SqlDataAdapter(cmdSelect);
                daObj.Fill(ds);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conObj.Close();
            }
            return ds;

            }
        public DataSet GetUderDetailsByUserId(trkActivityDetailsModel model,int userid)
        {
            DataSet ds = new DataSet();
            SqlConnection conObj = null;
            SqlDataAdapter daObj;

            try
            {
                conObj = Connection.GetConnection();
                conObj.Open();

                string selectQuery = "select user_id,user_department,det_completedby from  MASTER_UserDetails join dummyActivityDetail on user_id=det_completedby where user_id=1";
                SqlCommand cmdSelect = new SqlCommand(selectQuery, conObj);
                cmdSelect.Parameters.AddWithValue("@id", 1);

                daObj = new SqlDataAdapter(cmdSelect);
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

        }
    }
