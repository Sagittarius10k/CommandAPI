using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static Character khight = new Character();

        [HttpGet(Name="GetCharacter")]
        public ActionResult<Character> Get()
        {
            return Ok(khight);
        }
    }
}