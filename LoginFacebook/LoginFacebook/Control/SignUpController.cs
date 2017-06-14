using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LoginFacebook.Control
{

    
    public class SignUpController
    {
        private int flag;

        public void setFlag(int _flag)
        {
            this.flag = _flag;
        }
        public int getFlag() {
            return this.flag;
        }

        public void signUp(String name, String lastName, String email, String pass, String rePass) {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connected"].ToString());
            connection.Open();
            String query = "insert into dbo.registro values('"+name+"' , '"+lastName+"', '"+email+"' , '"+pass+"' , '"+rePass+"' )";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            setFlag(1);
        }
    }
}