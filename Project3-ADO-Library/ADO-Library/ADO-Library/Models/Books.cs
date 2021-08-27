using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Library.Models
{
    public class Books
    {
        public long id { get; set; }

        public string title { get; set; }

        public long isbn { get; set; }

        public bool isVisible { get; set; }

        public int pagecount { get; set; }

        public DateTime createDate { get; set; }

        public DateTime updateDate { get; set; }
    }
}
