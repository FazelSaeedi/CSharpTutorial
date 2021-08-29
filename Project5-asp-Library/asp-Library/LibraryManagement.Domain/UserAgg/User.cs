using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Domain;
using LibraryManagement.Domain.ShelfAgg;


namespace LibraryManagement.Domain.UserAgg
{
    public class User : EntityBase
    {


        public string userName { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public bool isActive { get; set; }
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
        }

        public void Edit(string userName, string password, string phone , bool isActive)
        {
            this.userName = userName;
            this.password = password;
            this.phone = phone;
            this.isActive = isActive;
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
