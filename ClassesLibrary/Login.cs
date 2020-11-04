using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Login
    {
        private string _username;
        private string _password;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public Login(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public Login() { }

        public override string ToString()
        {
            return string.Format("{0} is the password for username {1}", Password, Username); 
        }
    }
}
