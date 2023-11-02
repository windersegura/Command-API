using CommandAPI.Data;
using CommandAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandController : Controller
    {
        private readonly ICommandRepo _repo;

        public CommandController(ICommandRepo repo)
        {
            _repo = repo;
        } 

        [HttpGet]
        public async Task<ActionResult<List<Command>>> GetAllCommands()
        {
            var commands = _repo.getAllCommand();
            return Ok(commands);
            //return NotFound();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Command>> GetCommand(int id)
        {
            var command = _repo.getCommand(id);
            return Ok(command);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Command command)
        {
            _repo.CreateCommand(command);
            return NoContent();
        }

    }
}