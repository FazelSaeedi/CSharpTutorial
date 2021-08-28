using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Controllers
{

    [Route("/customController/custom")]
    public class HomeController : Controller
    {


        [Route("myindex")]
        public string Index()
        {
            return "hi"; 
        }


        [Route("test")]
        public string test()
        {
            return "hi Test";
        }



        // [HttpGet("insert/{id?}")] -> optional -> ham mitone bashe ham mitone nabashe 
        // [HttpGet("insert/{id:int}")]
        // [HttpGet("insert/{id:string}")]
        [HttpGet("insert/{id}")]
        public long insert(long id)
        {
            return id;
        }

    }

}
