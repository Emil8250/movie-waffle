using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoveWaffle_API.Interfaces;
using MoveWaffle_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MoveWaffle_API.Controllers
{
    [Route("api/[controller]")]
    public class EntertainmentController : Controller
    {
        private readonly IReader _reader;
        private readonly IWriter _writer;
        private readonly ILogger<EntertainmentController> _logger;
        public EntertainmentController(IReader reader, IWriter writer, ILogger<EntertainmentController> logger)
        {
            _reader = reader;
            _writer = writer;
            _logger = logger;
        }

        // GET: api/values
        [HttpGet]
        public Television Get()
        {
            // temporary debug
            // _reader.GetTitles();
            var user = new User
            {
                ID = new Guid(),
                JoinDate = DateTime.Now,
                UserName = "Test"
            };
            var test = _writer.DeleteUser(Guid.Parse("72AF9006-A384-4BF5-0983-08D8E986D9F3"));
            _logger.LogInformation("Hej");
            return _reader.GetTelevision();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
