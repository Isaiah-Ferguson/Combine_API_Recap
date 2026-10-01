using Combine_API_Recap.Dtos;
using Combine_API_Recap.Models;
using Combine_API_Recap.Repository;

namespace Combine_API_Recap.Services
{
    public class CharacterServices : ICharacterServices
    {
        //can only be used within the class
        //readonly it can not be reassigned
        private readonly ICharacterRepository _repository;

        public CharacterServices(ICharacterRepository repository)
        {
            _repository = repository;
        }

        public List<CharacterGetDTO> GetAll()
        {
            return _repository.GetAll().Select(c => ToGetDTO(c)).ToList();
            //For Every Record in our DB we will Call ToGetDTO and apply that method to the record
        }

        public CharacterGetDTO? GetById(int id)
        {
            //We want to get our character based on their ID from the repo

            Character? player = _repository.GetById(id);

            if (player is null)
            {
                return null;
            }

            return ToGetDTO(player);
            //return type is CharDTO
            //The type from DB is Character
            //We use a helper function to change the data
        }

        //CharacterGetDTO what we pull from the Database
        //CharacterPostDTO is what is coming in from the Client (Postman)
        public CharacterGetDTO Create(CharacterPostDTO character)
        {
            Character player = new Character();

            player.Name = character.Name;
            player.Health = 500;
            Character created = _repository.Create(player);

            return ToGetDTO(created);
        }

        private static CharacterGetDTO ToGetDTO(Character character)
        {
            CharacterGetDTO outputDTO = new CharacterGetDTO();
            outputDTO.Id = character.Id;
            outputDTO.Name = character.Name;
            outputDTO.Health = character.Health;

            return outputDTO;
        }
    }
}