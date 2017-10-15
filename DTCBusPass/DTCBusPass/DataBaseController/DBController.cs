using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace DTCBusPass.DataBaseController
{
    public class DBController
    {
        private string DBConnection { get; set; }

        public string GetDBConnection()
        {
            try
            {
                DBConnection =  ConfigurationManager.ConnectionStrings["DBconnectionString"].ConnectionString;
                return DBConnection;
            }
            catch(Exception exp)
            {
                throw exp;
            }
        }
    }
}