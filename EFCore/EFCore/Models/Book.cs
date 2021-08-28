using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore.Models;
namespace EFCore.Models
{
    public class Book
    {

        public long id { get; set; }
        public string title { get; set; }
        public long isbn { get; set; }
        public bool isVisible { get; set; }
        public int pageCount { get; set; }
        public DateTime creationDate { get; set; }
        public List<BooksShelf> booksShelves { get; set; }

        public Book (string title , long isbn  , int pageCount )
        {

            this.title = title;
            this.isbn = isbn;
            this.isVisible = true;
            this.pageCount = pageCount;
            this.creationDate = DateTime.Now;
            
        }

        public void setBookVisibility(bool status)
        {
            this.isVisible = status ;
        }


        public void changeTitle(string title)
        {
            this.title = title;
        }
    }
}
