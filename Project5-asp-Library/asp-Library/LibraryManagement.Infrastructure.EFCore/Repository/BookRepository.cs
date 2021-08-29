using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Infrastructure;
using LibraryManagement.Application.Contract.Book;
using LibraryManagement.Domain.BookAgg;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Infrastructure.EFCore.Repository
{
    public class BookRepository : RepositoryBase<long , Book> , IBookRepository
    {

        public readonly EFContext _EFContext ;
        public BookRepository(EFContext context) : base(context)
        {
            _EFContext = context;
        }

        public BookViewModel get(long id)
        {

            return _EFContext.Books.Select(x => new BookViewModel()
            {
                id = x.id ,
                title = x.title ,
                isbn = x.isbn ,
                isVisible = x.isVisible ,
                pageCount = x.pageCount ,
                CreationDate = x.CreateionDate.ToString() 
            }).FirstOrDefault(x => x.id == id);

        }


    }
}
