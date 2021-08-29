using Framework.Infrastructure;
using LibraryManagement.Application.Contract.User;
using LibraryManagement.Domain.ShelfAgg;
using LibraryManagement.Domain.UserAgg;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Infrastructure.EFCore.Repository
{
    public class UserRepository : RepositoryBase<long, User>, IUserRepository
    {

        public readonly EFContext _EFContext;
        public UserRepository(EFContext context) : base(context)
        {
            _EFContext = context;
        }

        public UserViweModel get(long id)
        {
            return _EFContext.Users.Select(x => new UserViweModel()
            {
                id = x.id ,
                userName = x.userName ,
                phone = x.phone ,
                isActive = x.isActive,
                CreationDate = x.CreateionDate.ToString()
            }).FirstOrDefault(x => x.id == id);
        }
    }
}
