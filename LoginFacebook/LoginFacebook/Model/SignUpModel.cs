using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginFacebook.Model
{
    public class SignUpModel
    {
        private String name;
        private String lastName;
        private String email;
        private String pass;
        private String rePass;

        public void setName(String _name) {
            this.name = _name;
        }

        public String getName() {
            return this.name;
        }
        public void setLastName(String _lastName)
        {
            this.lastName = _lastName;
        }

        public String getLastName()
        {
            return this.lastName;
        }
        public void setEmail(String _email)
        {
            this.email = _email;
        }

        public String getEmail()
        {
            return this.email;
        }
        public void setPass(String _pass)
        {
            this.pass = _pass;
        }

        public String getPass()
        {
            return this.pass;
        }
        public void setRePass(String _rePass)
        {
            this.rePass = _rePass;
        }

        public String getRePass()
        {
            return this.rePass;
        }
    }
}