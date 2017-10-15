using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTCBusPass.CommonUtils;
using DTCBusPass.DataBaseController;
using DTCBusPass.Interfaces;
using DTCBusPass.Models;

namespace DTCBusPass.Controllers
{
    public class LoginController : IUser
    {
        public User GetUserDetails(string emailAddress)
        {
            try
            {
                DBInteraction db = new DBInteraction();
                List<Dictionary<string, Object>> parameter = new List<Dictionary<string, object>>();
                Dictionary<string, Object> tmp = new Dictionary<string, object>();
                tmp.Add("@EmailAddress",emailAddress);                
                parameter.Add(tmp);
                db.parameterList = parameter;
                User user = db.GetDataFromDBUsingProc(parameter,"Usp_GetUser");
                return user;
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }
    }
}