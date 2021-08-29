using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Application.Contract.BookShelf
{

    public class BookShelfViewModel
    {

        public string shelfName { get; set; }
        public string userName { get; set; }
        public string bookName{ get; set; }
        public bool isReaded { get; set; }

    }


}
