using Framework.Application;
using LibraryManagement.Domain.UserAgg;
using System.Collections.Generic;

namespace LibraryManagement.Application.Contract.User
{
    public interface IUserApplication
    {
        OperationResult Create(CreateUser command);

        OperationResult Edit(EditUser command);

        OperationResult Delete(long id);

        UserViweModel get(long id);

        List<UserViweModel> getAllBooks();
    }
}
