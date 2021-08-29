using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Domain;
using LibraryManagement.Domain.BookAgg;


namespace LibraryManagement.Domain.BookshelfAgg
{
    public interface IBookshelfRepository : IRepository<long, BookShelf>
    {
        int getUserBooksCount(long id);
        List<UsersBookStatusViewModel> getUserBooksStatus(long id);
    }
}
