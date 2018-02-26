using System;
namespace MTnew.Models
{
    public class Users
    {
        //private int uid { get; set; }
        private string username { get; set; }
        private string password { get; set; }

        public Users()
        {
        }

        public Users(string _username, string _password)
        {
            this.username = _username;
            this.password = _password;
        }

        public bool checkinformation()
        {
            if (this.username != null && this.password != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
