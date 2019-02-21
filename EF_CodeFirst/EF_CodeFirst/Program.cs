using System;
using System.Data.Entity;
using EF_CodeFirst.DBModels;

namespace EF_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<CodeFirst_EF>());

            using (CodeFirst_EF db = new CodeFirst_EF())
            {
                Player player1 = new Player("Neymar", "da Silva Santos", 9, 3);
                Player player2 = new Player("Leonel", "Messi", 10, 10);
                Player player3 = new Player("Sergio", "Ramos", 4, 5);
               
                Team team1 = new Team("UTV"); 
                team1.PlayersList.Add(player1);
                team1.PlayersList.Add(player2);

                Team team2 = new Team("AAT");
                team2.PlayersList.Add(player3);

                Trainer trainer1 = new Trainer("Diego", "Maradona", team1);
                Trainer trainer2 = new Trainer("Josep", "Guardiola", team2);

                Coach coach = new Coach("Pierre ", "Louis ji Collina");

                Game game1 = new Game(DateTime.Now, team1, team2, coach);
                db.Games.Add(game1);

                db.SaveChanges();  // IsFinished is 0
                
                Team winner = game1.Play();

                db.SaveChanges();  // IsFinished is 1  

                Console.WriteLine($"The winner is {winner.Name}");
            }

            Console.ReadKey(); 
        }
    }
}
