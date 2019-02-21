namespace EF_CodeFirst
{
    using EF_CodeFirst.DBModels;
    using System.Data.Entity;

    public class CodeFirst_EF : DbContext
    {
        public CodeFirst_EF()
            : base("name=CodeFirst_EF")
        {
        }

        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Coach> Coaches { get; set; }  
        public virtual DbSet<Team> Teams { get; set; }
    }
}