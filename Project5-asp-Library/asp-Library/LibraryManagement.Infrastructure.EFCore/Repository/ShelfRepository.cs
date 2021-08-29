using Framework.Infrastructure;
using LibraryManagement.Domain.ShelfAgg;
using LibraryManagement.Domain.UserAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Infrastructure.EFCore.Repository
{
    public class ShelfRepository : RepositoryBase<long, Shelf> , IShelfRepository
    {

        public readonly EFContext _EFContext;

        public ShelfRepository(EFContext context) : base(context)
        {
            _EFContext = context;
        }

        public List<Shelf> getUserSheves(long userId)
        {
            return _EFContext.Shelves.Where(x => x.userId == userId).ToList();
        }


    }
}
