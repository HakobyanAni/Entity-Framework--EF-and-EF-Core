using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EF_CodeFirst.DBModels
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        public string Name { get; set; }
        public List<Player> PlayersList { get; set; }

        public Team(string name)
        {
            Name = name;
            PlayersList = new List<Player>();
        }
    }
}
