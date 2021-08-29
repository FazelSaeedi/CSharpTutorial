using asp_Library.Tools;
using Framework.Domain;
using LibraryManagement.Application.Contract.Book;
using LibraryManagement.Domain.BookAgg;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace asp_Library.Controllers
{

    [Route("api/Book")]
    [ApiController]
    public class BookController : Controller
    {


        public readonly IBookApplication _bookApplication;



        public BookController(IBookApplication bookApplication)
        {
            _bookApplication = bookApplication;
        }




        [ServiceFilter(typeof(SecurityPageFilter))]
        [HttpGet("{id}")]
        public ToJson index(long id)
        {

            var book = _bookApplication.get(id);
            
            if(book != null)
                return new ToJson(new ResponseModel<BookViewModel>(book , "success", 200), HttpStatusCode.OK);
            else
                return new ToJson(new ResponseModel<BookViewModel>(book, "User Not found ", 500), HttpStatusCode.OK);

        }




        [HttpGet("GetAllBook")]
        public ToJson getAllBooks()
        {
            var books = _bookApplication.getAllBooks();

            if (books != null)
                return new ToJson(new ResponseModel<List<BookViewModel>>(books , "success", 200), HttpStatusCode.OK);
            else
                return new ToJson(new ResponseModel<List<BookViewModel>>(books , "User Not found ", 500), HttpStatusCode.OK);

        }




        [Route("Create")]
        [HttpPost]
        public ToJson Create([FromBody] CreateBook book)
        {
            var result = _bookApplication.Create(book);

            if(result.IsSuccedded)
                return new ToJson(new ResponseModel<CreateBook>("success", 200), HttpStatusCode.OK);
            else
                return new ToJson(new ResponseModel<CreateBook>("Operation Fail", 500), HttpStatusCode.OK);

        }




        [Route("Edit")]
        [HttpPost]
        public ToJson Edit([FromBody] EditBook book)
        {

            var result = _bookApplication.Edit(book);


            if (result.IsSuccedded)
                return new ToJson(new ResponseModel<EditBook>("success", 200), HttpStatusCode.OK);
            else
                return new ToJson(new ResponseModel<EditBook>("Operation Fail", 500), HttpStatusCode.OK);
        }




        [Route("Delete/{id}")]
        [HttpGet]
        public ToJson Delete(long id)
        {

            var result = _bookApplication.Delete(id);


            if (result.IsSuccedded)
                return new ToJson(new ResponseModel<EditBook>("success", 200), HttpStatusCode.OK);
            else
                return new ToJson(new ResponseModel<EditBook>("Operation Fail", 500), HttpStatusCode.OK);
        }



    }




}
