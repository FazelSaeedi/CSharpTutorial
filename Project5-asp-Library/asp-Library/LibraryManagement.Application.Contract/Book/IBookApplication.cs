using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Application;
using LibraryManagement.Domain.BookAgg;

namespace LibraryManagement.Application.Contract.Book
{
    public interface IBookApplication
    {

        OperationResult Create(CreateBook command);

        OperationResult Edit(EditBook command);
        OperationResult Delete(long id);

        BookViewModel get(long id);

        List<BookViewModel> getAllBooks();
    }
}
