using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Library.Models
{
    public class Shelves
    {
        public long id { get; set; }

        public string title { get; set; }

        public long userId { get; set; }

        public DateTime createDate { get; set; }

        public DateTime updateDate { get; set; }
    }
}
