using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Application.Contract.Book
{
    public class CreateBook
    {

        public string title { get; set; }
        public long isbn { get; set; }
        public int pageCount { get; set; }

    }

}
