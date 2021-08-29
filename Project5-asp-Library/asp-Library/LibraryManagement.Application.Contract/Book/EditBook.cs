namespace LibraryManagement.Application.Contract.Book
{
    public class EditBook : CreateBook
    {

        public long id { get; set; }
        public bool isVisible { get; set; }


    }

}
