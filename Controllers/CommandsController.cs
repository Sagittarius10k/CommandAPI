using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandAPIRepo _repository;

        public CommandsController(ICommandAPIRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandList = _repository.GetAllCommands();
            return Ok(commandList);
        }

        [HttpGet("{commandId}")]
        public ActionResult<Command> GetCommandById(int commandId)
        {
            var command = _repository.GetCommandById(commandId);
            return command == null ? NotFound() : Ok(command);
        }
    }
}