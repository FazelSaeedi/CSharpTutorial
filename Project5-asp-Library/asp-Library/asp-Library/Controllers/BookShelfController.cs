using asp_Library.Tools;
using Framework.Domain;
using LibraryManagement.Application.Contract.BookShelf;
using LibraryManagement.Domain.BookshelfAgg;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace asp_Library.Controllers
{
    [Route("api/BookShelf")]
    [ApiController]
    public class BookShelfController : Controller
    {

        public readonly IBookShelfApplication _bookShelfApplication;

        public BookShelfController(IBookShelfApplication bookShelfApplication)
        {
            _bookShelfApplication = bookShelfApplication;
        }

        [Route("getUserBooksCount/{id}")]
        [HttpGet]
        public ToJson getUserBooksCount(long id)
        {

            var result = _bookShelfApplication.getUserBooksCount(id);

            return new ToJson(new ResponseModel<int>(result, "success", 200), HttpStatusCode.OK);

        }

        [Route("getUsersBooksStatus/{id}")]
        [HttpGet]
        public ToJson getUsersBooksStatus(long id)
        {

            var result = _bookShelfApplication.getUserBooksStatus(id);

            return new ToJson(new ResponseModel<List<UsersBookStatusViewModel>>(result, "success", 200), HttpStatusCode.OK);

        }
    }
}
