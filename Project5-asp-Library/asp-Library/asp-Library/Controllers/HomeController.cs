using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_Library.Controllers
{
    [Route("/Home")]
    public class HomeController : Controller
    {


        [HttpGet("{id}")]
        public IActionResult index(int id)
        {
            return Ok();
        }


    }
}
