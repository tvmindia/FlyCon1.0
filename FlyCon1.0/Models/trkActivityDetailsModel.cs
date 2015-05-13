using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace FlyCon1._0.Models
{
    public class trkActivityDetailsModel
    {
        public List<trkActivityDetailsModel> PunchListColletion { get; set; }
        public int ActivityDetailsId
        { 
            get;
            set;
        }
        public int ActivityId
        {
            get;
            set;
        }
        public int TagId
        {
            get;
            set;
        }

        public DateTime StartDate
        {
            get;
            set;
        }

        public DateTime EndDate
        {
            get;
            set;

        }
        public int Status
        {
            get;
            set;
        }
        public string CompletedBy
        {
            get;
            set;
        }
        public int CompletedById
        {
            get;
            set;
        }
        public string ActivityDetailDescription
        {
            get;
            set;
        }
        public DataSet ds
        {
            get;

            set;
        }
        public string Department
        {
            get;
            set;
        }
        public double Budget
        {
            get;
            set;
        }
        public double Rate
        {
            get;
            set;
        }
        public double RateNorm
        {
            get;
            set;

        }

    }
}