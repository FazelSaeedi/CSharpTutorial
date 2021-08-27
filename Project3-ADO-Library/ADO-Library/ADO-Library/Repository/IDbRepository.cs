using ADO_Library.Models;
using ADO_Library.Models.User;
using ADO_Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Library.Repository
{
    public interface IDbRepository
    {
        List<Users> getUsers();

        List<Books> getBooks();

        List<Shelves> getUsersShelves(long id);

        int getUsersBooksCount(long id);

        int readedUserBooksCount(long id);

        int UnReadedUserBooksCount(long id);

        List<BooksStatus> GetBooksStatus(long id);


    }
}
