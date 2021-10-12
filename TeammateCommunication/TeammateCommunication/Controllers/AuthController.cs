using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeammateCommunication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        [HttpGet("GetLogin")]

        public IActionResult Get()
        {
            return Ok("GetLogin - ok");
        }
    }
}
