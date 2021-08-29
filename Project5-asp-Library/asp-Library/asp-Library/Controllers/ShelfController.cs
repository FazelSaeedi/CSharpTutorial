using asp_Library.Tools;
using Framework.Domain;
using LibraryManagement.Application.Contract.Shelf;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace asp_Library.Controllers
{
    [Route("api/Shelf")]
    [ApiController]
    public class ShelfController : Controller
    {

        public readonly IShelfApplication _shelfApplication;


        public ShelfController(IShelfApplication shelfApplication)
        {
            _shelfApplication = shelfApplication;
        }

        [HttpGet("GetUserShelves/{id}")]

         public ToJson getUserShelves(long id )
         {
             var userShelves = _shelfApplication.getUserSheves(id);

            if (userShelves != null)
                return new ToJson(new ResponseModel<List<UserShelvesViewModel>>(userShelves, "success", 200), HttpStatusCode.OK);
            else
                return new ToJson(new ResponseModel<List<UserShelvesViewModel>>(userShelves, "User Not found ", 500), HttpStatusCode.OK);

        }
    }
}
