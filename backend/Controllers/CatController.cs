using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shared;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Cat> Get()
        {
            var Cats = new List<Cat>();
            Cats.Add(new Cat { Name = "Felix" });
            Cats.Add(new Cat { Name = "Garfield" });

            return Cats;
        }
    }
}