using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace beastlies.Controllers
{
    public class ReptilesController : Controller
    {
        [Route("api/beastiary/reptiles/lizards")]
        [HttpGet]

        public string[] GetLizards()
        {
            return new string[] { "lizards" };
        }

        [Route("api/beastiary/reptiles/turtles")]
        [HttpGet]
        public string[] GetTurtles()
        {
            return new string[] { "what turtles?" };
        }

        [Route("api/beastiary/reptiles/snakes")]
        [HttpGet]
        public string[] GetSnakes()
        {
            return new string[] { "hissssss" };
        }

        [Route("api/beastiary/reptiles/dinosaurs")]
        [HttpGet]
        public string[] GetDinos()
        {
            return new string[] { "*TRex noise" };
        }

    }
}
