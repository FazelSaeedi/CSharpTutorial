using Framework.Application;
using LibraryManagement.Application.Contract.BookShelf;
using LibraryManagement.Domain.BookshelfAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Application
{
    public class BookShelfApplication : IBookShelfApplication
    {
        public readonly IBookshelfRepository _bookShelfRepository;

        public BookShelfApplication(IBookshelfRepository bookShelfRepository)
        {
            _bookShelfRepository = bookShelfRepository;
        }

        public OperationResult Create(CreateBookShelf command)
        {
            throw new NotImplementedException();
        }

        public OperationResult Edit(EditBookShelf command)
        {
            throw new NotImplementedException();
        }

        public int getUserBooksCount(long id)
        {
            return _bookShelfRepository.getUserBooksCount(id);
        }

        public List<UsersBookStatusViewModel> getUserBooksStatus(long id)
        {
            return _bookShelfRepository.getUserBooksStatus(id);
        }
    }
}
