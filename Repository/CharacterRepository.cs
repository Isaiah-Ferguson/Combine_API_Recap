using Combine_API_Recap.Data;
using Combine_API_Recap.Models;

namespace Combine_API_Recap.Repository
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly AppDbContext _db; //this is the shape of our db without any of the content yet

        public CharacterRepository(AppDbContext db)
        {
            _db = db; //We are assigning all the functionality of our database to our _db
        }

        public List<Character> GetAll()
        {
            return _db.Characters.ToList();
        }

        public Character? GetById(int id)
        {
            return _db.Characters.Find(id);
        }

        public Character Create(Character newCharacter)
        {
            _db.Characters.Add(newCharacter);
            _db.SaveChanges();
            return newCharacter;
        }

    }
}