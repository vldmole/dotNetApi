using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace api.controllers
{
    [ApiController]
    [Route("[user]")]
    public class UserController : ControllerBase
    {
        [HttpGet("currentDateTime")]
        public IActionResult currentDateTime()
        {
            return Ok(new
            {
                Date = DateTime.Now.ToLongDateString(),
                Time = DateTime.Now.ToShortTimeString()
            });
        }
    }
}