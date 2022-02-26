using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP_OOP
{
    class User
    {
        private static string _userName;

        public string userName
        {
            get{
                return userName;
            }
            set
            {
                if (userName != "")
                {
                    _userName = userName;
                }
            }
        }

        public User(string user)
        {
            _userName = user;
        }
        
    }
}
