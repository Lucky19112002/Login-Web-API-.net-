using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace LoginWebAPI.Models
{
    //Data Access Layer
    public class DAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["webapicon"].ConnectionString);
        SqlDataAdapter da= null;
        DataTable dt = null;

        public string Login(Login login)
        {
            da = new SqlDataAdapter("select * from users where Username= '" + login.Username+ "' and Password='" + login.Password+"' ",con);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return "Logged IN";
            else
                return "Logging FAIL";
        }
    }
}