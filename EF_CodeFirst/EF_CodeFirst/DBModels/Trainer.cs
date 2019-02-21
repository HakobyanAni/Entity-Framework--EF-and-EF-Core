using System.ComponentModel.DataAnnotations;

namespace EF_CodeFirst.DBModels
{
    public class Trainer : Person
    {
        [Key]
        public int TrainerId { get; set; }

        [Required]
        public Team TrainerTeamId { get; set; }

        public Trainer(string firstName, string lastName, Team trainerTeamId)
            : base(firstName, lastName)
        {
            TrainerTeamId = trainerTeamId;
        }
    }
}
