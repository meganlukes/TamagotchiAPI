using System;
namespace TamagotchiAPI.Models
{
    public class Playtimes
    {
        public int Id { get; set; }
        public DateTime When { get; set; }
        public int PetID { get; set; }
        public Pets Pets { get; set; }
    }
}