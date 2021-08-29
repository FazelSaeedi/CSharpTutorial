using Framework.Application;
using LibraryManagement.Application.Contract.User;
using LibraryManagement.Domain.UserAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Application
{
    public class UserApplication : IUserApplication
    {

        public readonly IUserRepository _userRepository ;

        public UserApplication(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public OperationResult Create(CreateUser command)
        {
            var operation = new OperationResult();


             if (_userRepository.Exists(x => x.userName == command.userName))
                 return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var user = new User(command.userName, command.password, command.phone);
            _userRepository.Create(user);
            _userRepository.SaveChanges();

            return operation.Succedded();
        }


        public OperationResult Edit(EditUser command)
        {
            var operation = new OperationResult();
            User user = _userRepository.Get(command.id);

            if (user == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);


            user.Edit(command.userName , command.password ,command.phone , command.isActive);
            _userRepository.SaveChanges();

            return operation.Succedded();
        }


        public UserViweModel get(long id)
        {
            return _userRepository.get(id);
        }


        public OperationResult Delete(long id)
        {
            var operation = new OperationResult();


            _userRepository.Delete(id);
            _userRepository.SaveChanges();

            return operation.Succedded();
        }


        public List<UserViweModel> getAllBooks()
        {

            var books = _userRepository.Get();

            return (List<UserViweModel>)books.Select(x => new UserViweModel
            {

                id = x.id,
                userName = x.userName ,
                phone = x.phone ,
                isActive = x.isActive ,
                CreationDate = x.CreateionDate.ToString()

            }).ToList();

        }


    }
}
