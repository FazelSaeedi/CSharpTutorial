using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Application.Contract.User
{
    public class CreateUser
    {
        public string userName { get; set; }
        public string password { get; set; }
        public string phone { get; set; }

    }
}
