using Framework.Application;
using LibraryManagement.Application.Contract.Shelf;
using LibraryManagement.Domain.ShelfAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Application
{
    public class ShelfApplication : IShelfApplication
    {
        public readonly IShelfRepository _shelfRepository;

        public ShelfApplication(IShelfRepository shelfRepository)
        {
            _shelfRepository = shelfRepository;
        }

        public OperationResult Create(CreateShelf command)
        {
            var operation = new OperationResult();


            if (_shelfRepository.Exists(x => x.title == command.title))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var shelf = new Shelf(command.title  , command.userId);
            _shelfRepository.Create(shelf);
            _shelfRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditShelf command)
        {
            throw new NotImplementedException();
        }

        public List<UserShelvesViewModel> getUserSheves(long userId)
        {
            var s = _shelfRepository.getUserSheves(userId);


            return (List<UserShelvesViewModel>)s.Select(x => new UserShelvesViewModel
            {
                title = x.title ,
                CreationDate = x.CreateionDate.ToString()
            }).ToList();

        }
    }
}
