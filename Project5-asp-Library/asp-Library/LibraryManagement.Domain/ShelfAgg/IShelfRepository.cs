using Framework.Domain;
using LibraryManagement.Domain.UserAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Domain.ShelfAgg
{
    public interface IShelfRepository : IRepository<long, Shelf>
    {
        List<Shelf> getUserSheves(long userId);

    }
}
