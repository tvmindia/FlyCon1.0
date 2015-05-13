using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlyCon1._0.Models
{
    public class trkPunchListModel
    {
        public List<trkPunchListModel> PunchListCollection
        {
            get;
            set;
        }
        public string ProjNo
        {
            get;
            set;
        }
        public int IdNo
        {
            get;    
            set;
        } 
        public int LinkId
        {
            get;
            set;
        }
        public string PunchType
        {
            get;
            set;
        }
        public string OpenBy
        {
            get;
            set;
        }
        public DateTime OpenDt
        {
            get;
            set;
        }
        public string EnteredBy
        {
            get;
            set;
        }
        public DateTime EnteredDt
        {
            get;
            set;
        }
        public string Plant
        {
            get;
            set;
        }
        public string Area
        {
            get;
            set;
        }
        public string Location
        {
            get;
            set;
        }
        public string Unit
        {
            get;
            set;
        }

    }
   
    }
