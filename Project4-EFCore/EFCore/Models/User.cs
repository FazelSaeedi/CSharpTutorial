using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Models
{
    public class User
    {

        public long id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public bool isActive { get; set; }
        public DateTime creationDate { get; set; }
        public List<Shelf> shelves { get; set; }


        public User()
        {
          
        }

        public User(string userName, string password, string phone)
        {
            this.userName = userName;
            this.password = password;
            this.phone = phone;
            this.isActive = true;
            this.creationDate = DateTime.Now;
        }

        public void changePhone(string phone)
        {
            this.phone = phone;
        }

        public void changeUserName(string userName)
        {
            this.userName = userName;
        }

        public void changePassword(string password)
        {
            this.password = password;
        }

        public void setUserActive(bool status)
        {
            this.isActive = status;
        }

    }
}
