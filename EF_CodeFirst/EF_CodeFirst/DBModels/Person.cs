using System.ComponentModel.DataAnnotations;

namespace EF_CodeFirst.DBModels
{
    public class Person
    {
        [Required, MaxLength(15)]
        public string FirstName { get; set; }

        [Required, MaxLength(20)]
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
