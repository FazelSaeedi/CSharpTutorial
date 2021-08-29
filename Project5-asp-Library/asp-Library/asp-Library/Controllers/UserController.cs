using asp_Library.Tools;
using Framework.Domain;
using LibraryManagement.Application.Contract.User;
using LibraryManagement.Domain.UserAgg;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace asp_Library.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : Controller
    {

        public readonly IUserApplication _userApplication;

        public UserController(IUserApplication userApplication)
        {
            _userApplication = userApplication;
        }


         [HttpGet("{id}")]
         public ToJson index(long id)
         {
         
            var user = _userApplication.get(id);
            
         
            if (user != null)
                return new ToJson(new ResponseModel<UserViweModel>(user, "success", 200), HttpStatusCode.OK);
            else
                return new ToJson(new ResponseModel<UserViweModel>(user, "User Not found ", 500), HttpStatusCode.OK);
            
         
         }



        [Route("Create")]
        [HttpPost]
        public ToJson Create([FromBody] CreateUser user)
        {
            var result = _userApplication.Create(user);

            if (result.IsSuccedded)
                return new ToJson(new ResponseModel<CreateUser>("success", 200), HttpStatusCode.OK);
            else
                return new ToJson(new ResponseModel<CreateUser>("Operation Fail", 500), HttpStatusCode.OK);

        }



        [Route("Edit")]
        [HttpPost]
        public ToJson Edit([FromBody] EditUser book)
        {

            var result = _userApplication.Edit(book);


            if (result.IsSuccedded)
                return new ToJson(new ResponseModel<EditUser>("success", 200), HttpStatusCode.OK);
            else
                return new ToJson(new ResponseModel<EditUser>("Operation Fail", 500), HttpStatusCode.OK);
        }


        [Route("Delete/{id}")]
        [HttpGet]
        public ToJson Delete(long id)
        {

            var result = _userApplication.Delete(id);


            if (result.IsSuccedded)
                return new ToJson(new ResponseModel<EditUser>("success", 200), HttpStatusCode.OK);
            else
                return new ToJson(new ResponseModel<EditUser>("Operation Fail", 500), HttpStatusCode.OK);
        }


        [HttpGet("GetAllUsers")]
        public ToJson getAllBooks()
        {
            var users = _userApplication.getAllBooks();

            if (users != null)
                return new ToJson(new ResponseModel<List<UserViweModel>>(users, "success", 200), HttpStatusCode.OK);
            else
                return new ToJson(new ResponseModel<List<UserViweModel>>(users, "User Not found ", 500), HttpStatusCode.OK);

        }



    }
}
