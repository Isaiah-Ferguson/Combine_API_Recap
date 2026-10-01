using Combine_API_Recap.Dtos;

namespace Combine_API_Recap.Services
{
    public interface ICharacterServices
    {
        // I want a Get All
        List<CharacterGetDTO> GetAll(); // We return GetDTO because we are GETTING information FROM our DB
        
        CharacterGetDTO GetById(int id);

        CharacterGetDTO Create(CharacterPostDTO newCharacter); //Param POST because we are sending information TO our DB
    }
}