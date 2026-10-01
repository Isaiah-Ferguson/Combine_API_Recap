using Combine_API_Recap.Dtos;
using Combine_API_Recap.Services;
using Microsoft.AspNetCore.Mvc;

namespace Combine_API_Recap.Controllers
{
    [ApiController]
    [Route("[controller]")]// -> /Character
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterServices _services;

        public CharacterController(ICharacterServices services)
        {
            _services = services;
        }

        [HttpGet("GetAll")]
        public ActionResult<List<CharacterGetDTO>> GetAllCharacters()
        {
            return Ok(_services.GetAll());
        }

        [HttpGet("GetById/{id}")]
        public ActionResult<CharacterGetDTO> GetById(int id)
        {
            CharacterGetDTO? character = _services.GetById(id);

            if (character is null)
            {
                return NotFound($"No Character with id: {id} is in our DB");
            }

            return Ok(character);
        }

        [HttpPost("Add")]
        public ActionResult<CharacterGetDTO> Create([FromBody] CharacterPostDTO newCharacter)
        {
            CharacterGetDTO character = _services.Create(newCharacter);

            return CreatedAtAction(
                nameof(GetById),
                new { id = character.Id },
                character
            );
        }
    }
}