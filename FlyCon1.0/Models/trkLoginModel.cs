using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlyCon1._0.Models
{
    public class trkLoginModel
    {
        public string UserName
        {
            get;
            set;
        }
        public string ProjNo
        {
            get;
            set;  
        }
        public string ProjPreference
        {
            get;
            set;
        }
          public IEnumerable<dynamic> Rows { get; set; }
  }
    }
