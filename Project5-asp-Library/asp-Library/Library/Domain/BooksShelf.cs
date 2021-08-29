using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.Models;

namespace EFCore.Models
{
    public class BooksShelf
    {

        public long id { get; set; }
        public long shelfId { get; set; }
        public long bookId { get; set; }
        public bool isReaded { get; set; }
        public DateTime creationDate { get; set; }
        public Book book { get; set; }
        public Shelf shelf { get; set; }

        public BooksShelf()
        {

        }
        public BooksShelf(long shelfId , long bookId )
        {

            this.shelfId = shelfId;
            this.bookId = bookId;
            this.isReaded = false;
            this.creationDate = DateTime.Now;

        }

        public void readBook(bool status)
        {
            this.isReaded = status;
        }

    }
}
