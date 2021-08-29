namespace LibraryManagement.Domain.BookAgg
{
    public class BookViewModel
    {

        public long id { get; set; }
        public string title { get; set; }
        public long isbn { get; set; }
        public bool isVisible { get; set; }
        public int pageCount { get; set; }
        public string CreationDate { get; set; }

    }

}
