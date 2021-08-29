using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Domain.BookshelfAgg
{
    public class UsersBookStatusViewModel
    {
        public string title { get; set; }

        public string shelfTitle { get; set; }

        public bool isReaded { get; set; }
    }
}
