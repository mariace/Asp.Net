using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using LoginFacebook.Model;
using System.Data;

namespace LoginFacebook.Controller
{
    public class LoginController:LoginModel
    {

        LoginModel log = new LoginModel();
      

        private int flag;
        public void setFlag(int _flag) {
            this.flag = _flag;
        }

        public int getFlag() {
            return this.flag;
        }
        public void action(String name, String pass) {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connected"].ToString());
            connection.Open();
            String query = "select count (*) from dbo.ingresar where nombre= '" + name + "' and pass ='" + pass +"' ";
            SqlCommand cmd = new SqlCommand(query, connection);
            string output = cmd.ExecuteScalar().ToString();
            
                if (output == "1")
                {
                    setFlag(1);
                }
            connection.Close(); 
        }
    }
}