using System.ComponentModel.DataAnnotations;

namespace EF_CodeFirst.DBModels
{
    public class Player : Person
    {
        [Key]
        public int PlayerId { get; set; }

        [Required]
        public int Number { get; set; }

        public int? Goals { get; set; }

        public Player(string firstName, string lastName, int number, int goals)
            : base(firstName, lastName)
        {
            Number = number;
            Goals = goals; 
        }
    }
}
