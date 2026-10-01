using Combine_API_Recap.Models;

namespace Combine_API_Recap.Repository
{
    public interface ICharacterRepository
    {
        //get all getby id create delete update

        List<Character> GetAll();

        Character? GetById(int id); //Paramter is the SHAPE of the data that WILL be passed in

        Character Create(Character newCharacter);

    }
}