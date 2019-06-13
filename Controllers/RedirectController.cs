using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareAssassin.Controllers
{
    [Route("[controller]")]
    public class RedirectController : ControllerBase
    {
        [HttpPost]
        public IActionResult Submit()
        {
            return Redirect("https://www.google.com/");
        }
    }
}
