using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace beastlies.Controllers
{
    public class WelcomeController : Controller
    {

        [Route("/")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "welcome" };
        } 
    }
}
