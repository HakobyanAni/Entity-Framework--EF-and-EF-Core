using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_CodeFirst.DBModels
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }

        [Column(TypeName ="datetime2")]
        public DateTime? Date { get; set; }
    
        public Team HomeTeamId { get; set; }
        public Team GuestTeamId { get; set; } 
        public bool IsFinished { get; set; }
        public Team WinnerTeamId { get; set; }
        public Coach CoachId { get; set; }

        public Game(DateTime date, Team homeTeamId, Team guestTeamId, Coach coachId)
        {
            Date = date;
            HomeTeamId = homeTeamId;
            GuestTeamId = guestTeamId;
            CoachId = coachId;
        }

        public Team Play()
        {
            Random rd = new Random();
            int goalHome = rd.Next(0, 10);
            int goalGuest = rd.Next(0, 10);
            this.IsFinished = true;

            return goalHome > goalGuest ? this.HomeTeamId : this.GuestTeamId;
        }
    }
}
