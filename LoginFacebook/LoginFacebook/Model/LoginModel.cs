using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginFacebook.Model
{
    public class LoginModel
    {
        private String name;
        private String pass;

        public LoginModel() { }
        public LoginModel( String _name, String _pass) {
            this.name = _name;
            this.pass = _pass;
        }

        public void setName(String _name) {
            this.name = _name;
        }

        public String getName() {
            return this.name;
        }

        public void setPass(String _pass)
        {
            this.pass = _pass;
        }

        public String getPass()
        {
            return this.pass;
        }
    }
}