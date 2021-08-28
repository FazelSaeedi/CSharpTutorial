using EFCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace EFCore.Controllers
{
    [Route("/books")]
    public class BookController : Controller
    {
        private readonly LibContext _context;

        public BookController(LibContext context)
        {
            _context = context;
        }


        [HttpGet("")]
        public string index()
        {
            // var books = _context.books.ToList();

            // var book = _context.books.FirstOrDefault();             // if exist return first element or default value without exception
            // var book = _context.books.FirstOrDefault(x => x.isVisible.Equals(true));
            // var book = _context.books.First(x => x.id == 25);   // if is not exist exception happen


            // var book = _context.books.SingleOrDefault(x => x.id == 25);    // return if just one element be exist otherwise return default value like null 
            // var book = _context.books.Single(x => x.id == 25);    // return if just one element be exist otherwise exception


            // var book = _context.books.Find(1);    // accept just id  Notice = first search in memory if is not exist connect and send query to database

            // var book = _context.books.Where(x => x.pageCount < 100);
            // var book = _context.books.Max(x => x.isbn);
            // var book = _context.books.Min(x => x.isbn);
            // var book = _context.books.Count();
            // var book = _context.books.LongCount();

            // var exist = _context.books.Any(x => x.id == 1 );  // exist shart ro check mikonad
            // var book = _context.books.All(x => x.id == 1 );   // naghz sharayet ro check mikonad




              var shelf = _context.shelves
                  .Include(x => x.user)
                  .Include(x => x.booksShelves)
                      .ToList();

            
            //var shelfs = _context.shelves.Include().ToList();
            return "Ok";

        }

        [HttpGet("create")]
        public string create()
        {

            var book1 = new Book("book1"+ new Random().Next(0, 999999).ToString(), new Random().Next(0 , 999999) , 125);
            _context.Add(book1);
            _context.SaveChanges();
            return "ok";

        }


        [HttpGet("update")]
        public string update()
        {
            var product = _context.books.Find(3);
            product.isbn = 5555555555;
            _context.SaveChanges();
            return "ok";
        }


        [HttpPost("test")]
        public ToJson testValidation([FromBody]InsertUserModel insertUserModel)
        {


            var user = new User("s", "2", "09366285660");
            user.shelves = new List<Shelf>();

            user.shelves.Add(new Shelf("hi", user.id));
            user.shelves.Add(new Shelf("hi2", user.id));


            return new ToJson(new ResponseModel<User>(user, "success" , 200 ), HttpStatusCode.NotFound);




            // Some Example -----------------------------------------------------------------------


            // var s = new Response<InsertUserModel>(200, "", insertUserModel);
            // var User1 = new Message<User>();
            // User1.status = 200;
            // User1.message = "success";
            // User1.data = user;
            // 
            // return Json(User1);


            // Set a json object to return. The status code defaults to 500
            // return new ResMsg(user , HttpStatusCode.NotFound);


            // bool isValid = ModelState.IsValid;
            // var jsonStringName = new JavaScriptSerializer();
            // return jsonStringName.Serialize(new Response<InsertUserModel>(200, "", insertUserModel));
            // return EFCore.Response.show();

        }


        [HttpPost("register")]
        public IActionResult Register([FromBody] User user)
        {
            //.. code  here 
            return Ok();
        }


     

    }


    public class ResponseModel<T>
    {
        public string message { get; set; }
        public int statusCode { get; set; }
        public T data { get; set; }

        public ResponseModel(T data , string message , int statusCode )
        {
            this.data = data ;
            this.message = message ;
            this.statusCode = statusCode;
        }
    }



}
