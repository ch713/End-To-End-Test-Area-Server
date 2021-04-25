using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using End_To_End_Test_Area_Server.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;


namespace End_To_End_Test_Area_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public TestClass Get()
        {
            string jsonString = System.IO.File.ReadAllText(@"Resources/TestJSON.txt");

            TestClass jsonObject = JsonConvert.DeserializeObject<TestClass>(jsonString);
            return jsonObject;
        }
    }
}