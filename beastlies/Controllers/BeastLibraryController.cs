using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace beastlies.Controllers
{
    public class BeastLibraryController : Controller
    {

        [Route("api/beastiary")]
        [HttpGet]

        public string Get()
        {
            return "initial top tier list";
        }

        [Route("api/beastiary/reptiles")]
        [HttpGet]
        public IEnumerable<string> Reptiles()
        {
            return new string[] { "Alligator", "Tortois", "Python" };
        }

        [Route("api/beastiary/birds")]
        [HttpGet]

        public IEnumerable<string> Birds()
        {
            return new string[] { "eagle", "hawk", "sparrow", "penguin" };
        }

        [Route("api/beastiary/kanines")]
        [HttpGet]

        public IEnumerable<string> Kanines()
        {
            return new string[] { "Dire Wolf", "Pitbull", "Great Dane", "Chihuahua" };
        }
    }
}
