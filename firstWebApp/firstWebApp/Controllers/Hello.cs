using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class sravanthi : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World");
        }
        [HttpGet]
        [Route("myapplication")]
        public IActionResult GetMyApplication()
        {
            return Ok("Hello World Application");
        }
        [HttpPost]
        public IActionResult post(JObject payload )
        {
            return Ok(payload);

        }
    }
}
