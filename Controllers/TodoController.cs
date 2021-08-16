using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MyList.Actions;
using MyList.Model;

namespace MyList.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
      
        private readonly IRepository repository;
        private readonly IConfiguration config;
        private readonly ILogger<TodoController> _logger;

        public TodoController(ILogger<TodoController> logger, IRepository repository, IConfiguration config  )
        {
            _logger = logger;
            this.repository = repository;
            this.config = config;
        }

        [HttpGet]
        public async Task<IEnumerable<Todo>> GetItemsAsync()
        {
            Console.WriteLine("I am bbbbbbbbbbbbbbbb");
            var data = await repository.GetItemsAsync();
            return data;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Todo>> GetItemAsync(int id){
            var data = await repository.GetItemAsync(id);
            if(data is null){
                return NotFound();
            }
            return Ok(data);
        }

            [HttpGet]
            [Route("config")]
        public  string GetConfig(int id){
            var configuration = config["ConnectionStrings:connect"];
            return configuration;
        }
    }
}
