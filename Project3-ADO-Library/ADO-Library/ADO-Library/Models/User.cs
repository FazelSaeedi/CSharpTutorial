using System;



namespace ADO_Library.Models.User
{

    public class Users
    {

        public Users()
        {

        }

        public int id { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string userName { get; set; }

        public string password { get; set; }

        public string phone { get; set; }

        public bool isActive { get; set; }

        public DateTime createDate { get; set; }

        public DateTime updateDate { get; set; }


    }

}

