using ADO_Library.Models;
using ADO_Library.Models.User;
using ADO_Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ADO_Library.Program;

namespace ADO_Library.Repository
{
    public class DbRepository : IDbRepository
    {




        public List<Books> getBooks() => new Database().ExecuteQuery<Books>("select * from Books").ToList<Books>();




        public List<BooksStatus> GetBooksStatus(long id) => new Database().ExecuteQuery<BooksStatus>
            ("SELECT[booksShelves].id , books.title ,[booksShelves].isReaded FROM booksShelves " +
            "INNER JOIN Shelves ON[booksshelves].shelfId = shelves.id " +
            "INNER JOIN users  ON[shelves].userid = users.id " +
            $"INNER JOIN books  ON[booksShelves].bookid = books.id where users.id = {id} ;")
            .ToList<BooksStatus>();





        public List<Users> getUsers() => new Database().ExecuteQuery<Users>("select * from Users").ToList<Users>();




        public int getUsersBooksCount(long id) => new Database()
                .ExecuteScalar<int>($"SELECT count([booksShelves].bookId) FROM[library].[dbo].[booksShelves] INNER JOIN Shelves ON[booksshelves].shelfId = shelves.id where[shelves].userid = {id};");




        public List<Shelves> getUsersShelves(long id) => new Database()
                .ExecuteQuery<Shelves>($"select * from shelves where id = {id}").ToList<Shelves>();




        public int readedUserBooksCount(long id) => new Database()
                .ExecuteScalar<int>($"SELECT count(booksShelves.bookId) FROM booksShelves " +
            $"INNER JOIN Shelves ON booksshelves.shelfId = shelves.id where shelves.userid = {id};");




        public int UnReadedUserBooksCount(long id) => new Database()
                .ExecuteScalar<int>($"SELECT  count(*) FROM booksShelves " +
            $"INNER JOIN Shelves  ON booksShelves.shelfId = Shelves.id " +
            $"INNER JOIN users  ON Shelves .userid = users.id " +
            $"where users.id = {id} AND booksShelves.isReaded = 1 ;");


    }
}
