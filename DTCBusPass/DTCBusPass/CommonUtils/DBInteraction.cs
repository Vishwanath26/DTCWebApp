using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using DTCBusPass.DataBaseController;
using DTCBusPass.Models;

namespace DTCBusPass.CommonUtils
{
    public class DBInteraction
    {
        public List<Dictionary<string, Object>> parameterList { get;set;}
        public User GetDataFromDBUsingProc(List<Dictionary<string, Object>> parameterList,string procName)
        {
            try {           
                DBController cntrl = new DBController();
                string dbString = cntrl.GetDBConnection();
                User newUser = new User();
                using (SqlConnection conn = new SqlConnection(dbString))
                {
                    using (SqlCommand cmd = new SqlCommand(procName, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        foreach (Dictionary<string, Object> param in parameterList)
                        {
                            List<string> ColParamNames = param.Keys.ToList();
                            Object value = param[ColParamNames[0]];
                            cmd.Parameters.AddWithValue(ColParamNames[0], value);
                        }
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                newUser.firstName = reader["FirstName"].ToString();
                                newUser.surName = reader["SurName"].ToString();
                                newUser.emailAddress = reader["EmailAddress"].ToString();
                                newUser.password = reader["Password"].ToString();
                                newUser.birthDate = Convert.ToDateTime(reader["BirthDate"]);
                                newUser.location = reader["Location"].ToString();
                                newUser.gender = reader["Gender"].ToString();
                            }
                        }
                    }
                }
                return newUser;
            }
            catch(Exception exp)
            {
                throw exp;
            }
        }
    }
}