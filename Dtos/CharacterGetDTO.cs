namespace Combine_API_Recap.Dtos
{
    //We will Exclude information from our model that our clident doesn't want to see
    public class CharacterGetDTO
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public int Health {get;set;}

    }
}