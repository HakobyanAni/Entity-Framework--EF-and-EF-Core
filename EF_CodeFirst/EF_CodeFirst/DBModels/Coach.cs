using System.ComponentModel.DataAnnotations;

namespace EF_CodeFirst.DBModels
{
    public class Coach : Person
    {
        [Key]
        public int CoachId { get; set; }

        public Coach(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }
    }
}
