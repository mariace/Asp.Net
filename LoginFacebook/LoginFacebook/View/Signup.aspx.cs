using LoginFacebook.Control;
using LoginFacebook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginFacebook.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SignUpController signUpController = new SignUpController();
            SignUpModel signUpModel = new SignUpModel();
            signUpModel.setName(txtName.Text);
            signUpModel.setLastName(txtLastName.Text);
            signUpModel.setEmail(txtEmail.Text);
            signUpModel.setPass(txtPass.Text);
            signUpModel.setRePass(txtRePass.Text);
            signUpController.signUp(signUpModel.getName(),signUpModel.getLastName(),signUpModel.getEmail(),signUpModel.getPass(),signUpModel.getRePass());
            if (signUpController.getFlag() == 1)
            {
                lblMessage.Text = "Well Done!!";
            }
        }
    }
}