using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace finalooadproject.Business_Logic_Layer
{
   public class bll_signupemployee
    {
        public void insertemployee(string username,string password) {
            DAL obj = new DAL();
            obj.OpenConnection();
            obj.LoadSpParameters("_spinsert", username, password);

            

            obj.ExecuteQuery();
            obj.UnLoadSpParameters();
            obj.CloseConnection();

        }
    }
}
