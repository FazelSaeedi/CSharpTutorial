using Framework.Application;
using System.Collections.Generic;

namespace LibraryManagement.Application.Contract.Shelf
{
    public interface IShelfApplication
    {
        OperationResult Create(CreateShelf command);

        OperationResult Edit(EditShelf command);

        List<UserShelvesViewModel> getUserSheves(long userId);
    }

}
