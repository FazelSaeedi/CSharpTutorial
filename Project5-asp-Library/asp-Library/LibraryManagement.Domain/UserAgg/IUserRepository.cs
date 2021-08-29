using Framework.Domain;
using LibraryManagement.Domain.BookAgg;
using LibraryManagement.Domain.ShelfAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Domain.UserAgg
{
    public interface IUserRepository : IRepository<long, User>
    {
        UserViweModel get(long id);
    }
}
