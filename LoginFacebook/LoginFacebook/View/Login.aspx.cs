using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using LoginFacebook.Controller;
using LoginFacebook.Model;

namespace Login
{
  
    public partial class Login : System.Web.UI.Page
    {
        LoginController logController = new LoginController();
        LoginModel logModel = new LoginModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("~/View/Welcome.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            
             logModel.setName(txtUser.Text);
             logModel.setPass(txtPass.Text);
             
            logController.action(logModel.getName(),logModel.getPass());
            if (logController.getFlag()==1)
            {
                Session["user"] = txtUser.Text;
                Response.Redirect("~/View/Welcome.aspx");
            }

            else
            {
                Response.Write("Login Failed");
            }
        }

        protected void txtUser_TextChanged(object sender, EventArgs e)
        {
            logModel.setName(txtUser.Text);
        }

        protected void txtPass_TextChanged(object sender, EventArgs e)
        {
            logModel.setPass(txtPass.Text);
        }
        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Signup.aspx");
        }
    }
 }