using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore.Models;

namespace EFCore.Models
{
    public class Shelf
    {

        public long id { get; set; }
        public string title { get; set; }
        public long userId { get; set; }
        public DateTime creationDate { get; set; }
        public User user { get; set; }
        public List<BooksShelf> booksShelves { get; set; }

        public Shelf()
        {
            
        }
        public Shelf(string title , long userId)
        {
            this.title = title;
            this.userId = userId;
            creationDate = DateTime.Now;
        }


        public void changeTitle(string title)
        {
            this.title = title;
        }

    }
}
