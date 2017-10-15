using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Serialization;
using DTCBusPass.Controllers;
using DTCBusPass.Models;

namespace DTCBusPass.Services
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class UserInteraction
    {
      //login method
        [OperationContract]
        public string GetUserDetails(string emailAddress)
        {
            string message = string.Empty;
            try
            {
                LoginController loginCntrl = new LoginController();
                User user = loginCntrl.GetUserDetails(emailAddress);
                message = new JavaScriptSerializer().Serialize(user);
                return message;
            }
            catch(Exception exp)
            {
                message = "Error in service";
                return message + "\t Exception=>" +exp.InnerException;
            }
        }
    }
}
