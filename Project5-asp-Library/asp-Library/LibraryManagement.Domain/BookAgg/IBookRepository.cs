using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Domain;

namespace LibraryManagement.Domain.BookAgg
{
    public interface IBookRepository : IRepository<long, Book>
    {
        BookViewModel get(long id);
    }
}
