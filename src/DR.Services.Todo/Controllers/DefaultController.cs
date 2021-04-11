using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DR.Services.Todo.Controllers
{
    [ApiController]
    [Route("")]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("DR Todo Service");
    }
}
