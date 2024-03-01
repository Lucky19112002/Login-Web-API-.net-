using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginWebAPI.Models
{
    //Business Access Layer 
    //brige between frontend and DAL
    public class BAL
    {
        public string GetLogin(Login login)
        {
            DAL dal = new DAL();
            string response = dal.Login(login);
            return response;
        }
    }
}