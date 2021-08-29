using Framework.Infrastructure;
using LibraryManagement.Application.Contract.BookShelf;
using LibraryManagement.Domain.BookshelfAgg;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Infrastructure.EFCore.Repository
{
    public class BookShelfRepository : RepositoryBase<long, BookShelf>, IBookshelfRepository
    {

        public readonly EFContext _EFContext;
        public BookShelfRepository(EFContext context) : base(context)
        {
            _EFContext = context;
        }

        public int getUserBooksCount(long id)
        {
            return _EFContext.BookShelves
                .Include(x => x.shelf)
                .Where(x => x.shelf.userId == id)
                .Count();

        }

        public List<UsersBookStatusViewModel> getUserBooksStatus(long id)
        {
            return  _EFContext.BookShelves
                .Include(x => x.shelf)
                .Include(x => x.book)
                .Where(x => x.shelf.userId == id)
                .Select(x => new UsersBookStatusViewModel 
                { 
                   title = x.book.title ,
                   shelfTitle = x.shelf.title,
                   isReaded = x.isReaded
                })
                .AsNoTracking()
                .ToList();

        }
    }
}
