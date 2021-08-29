using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Domain;
using LibraryManagement.Domain.BookshelfAgg;

namespace LibraryManagement.Domain.BookAgg
{
    public class Book : EntityBase
    {


        public string title { get; private set; }
        public long isbn { get; private set; }
        public bool isVisible { get; private set; }
        public int pageCount { get; private set; }
        public List<BookShelf> booksShelves { get; private set; }



        public Book(string title, long isbn, int pageCount)
        {
            this.title = title;
            this.isbn = isbn;
            this.isVisible = true;
            this.pageCount = pageCount;
        }

        public void Edit(string title, long isbn, int pageCount , bool isVisible)
        {
            this.title = title;
            this.isbn = isbn;
            this.isVisible = isVisible;
            this.pageCount = pageCount;
        }

        public void setBookVisibility(bool status)
        {
            this.isVisible = status;
        }
        public void changeTitle(string title)
        {
            this.title = title;
        }


    }
}
