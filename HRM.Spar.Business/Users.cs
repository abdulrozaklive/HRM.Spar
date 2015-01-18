using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRM.Spar.Entities;

namespace HRM.Spar.Business
{
    public class Users
    {
        public sparEntities database = new sparEntities();
        public static bool Login(string username, string password)
        {
      
               
        

            
            return true;
        }

        public static bool Register(string username, string password, string fullName, string email)
        {
            return true;
        }
    }
}
