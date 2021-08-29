using Framework.Application;
using LibraryManagement.Domain.BookshelfAgg;
using System.Collections.Generic;

namespace LibraryManagement.Application.Contract.BookShelf
{
    public interface IBookShelfApplication
    {
        OperationResult Create(CreateBookShelf command);

        OperationResult Edit(EditBookShelf command);
        List<UsersBookStatusViewModel> getUserBooksStatus(long id);
        int getUserBooksCount(long id);
    }


}
