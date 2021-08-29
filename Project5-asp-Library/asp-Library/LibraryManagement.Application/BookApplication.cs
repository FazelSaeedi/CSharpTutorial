using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Application;
using LibraryManagement.Application.Contract.Book;
using LibraryManagement.Domain.BookAgg;


namespace LibraryManagement.Application
{

    public class BookApplication : IBookApplication
    {
        public readonly IBookRepository _bookRepository;

        public BookApplication(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public OperationResult Create(CreateBook command)
        {

            var operation = new OperationResult();
            

            if (_bookRepository.Exists(x => x.title == command.title))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var book = new Book(command.title , command.isbn , command.pageCount);
            _bookRepository.Create(book);
            _bookRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Delete(long id)
        {
            var operation = new OperationResult();


            _bookRepository.Delete(id);
            _bookRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditBook command)
        {

            var operation = new OperationResult();
            var book = _bookRepository.Get(command.id);

            if (book == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);


            book.Edit(command.title, command.isbn, command.pageCount, command.isVisible);
            _bookRepository.SaveChanges();

            return operation.Succedded();

        }

        public BookViewModel get(long id )
        {
            return _bookRepository.get(id);
        }

        public List<BookViewModel> getAllBooks()
        {
            var books =  _bookRepository.Get();

            return (List<BookViewModel>)books.Select(x => new BookViewModel
            {
                id = x.id ,
                title = x.title ,
                isbn = x.isbn ,
                pageCount = x.pageCount ,
                isVisible = x.isVisible ,
                CreationDate = x.CreateionDate.ToString()
            }).ToList();
        }


    }
}
