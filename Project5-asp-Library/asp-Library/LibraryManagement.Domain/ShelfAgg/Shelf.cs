using LibraryManagement.Domain.UserAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Domain;
using LibraryManagement.Domain.BookshelfAgg;

namespace LibraryManagement.Domain.ShelfAgg
{
    public class Shelf : EntityBase
    {


        public string title { get; set; }
        public long userId { get; set; }
        public User user { get; set; }
        public List<BookShelf> booksShelves { get; set; }



        public Shelf()
        {

        }
        public Shelf(string title, long userId)
        {
            this.title = title;
            this.userId = userId;
        }
        public void changeTitle(string title)
        {
            this.title = title;
        }


    }
}
