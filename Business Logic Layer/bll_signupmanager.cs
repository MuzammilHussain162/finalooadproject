using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;
namespace finalooadproject.Business_Logic_Layer
{
    public class bll_signupmanager
    {
        public void insertmanager(string username,string password) {
            DAL obj = new DAL();
            obj.OpenConnection();
            obj.LoadSpParameters("_spinsertmanager", username, password);
            obj.ExecuteQuery();
            obj.UnLoadSpParameters();
            obj.CloseConnection();


        }
    }
}
