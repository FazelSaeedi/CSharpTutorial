using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Domain;
using LibraryManagement.Domain.ShelfAgg;
using LibraryManagement.Domain.BookAgg;

namespace LibraryManagement.Domain.BookshelfAgg
{
    public class BookShelf : EntityBase
    {



        public long shelfId { get; set; }
        public long bookId { get; set; }
        public bool isReaded { get; set; }
        public Book book { get; set; }
        public Shelf shelf { get; set; }



        public BookShelf()
        {

        }
        public BookShelf(long shelfId, long bookId)
        {

            this.shelfId = shelfId;
            this.bookId = bookId;
            this.isReaded = false;

        }
        public void readBook(bool status)
        {
            this.isReaded = status;
        }


    }
}
