using System.ComponentModel.DataAnnotations;

namespace Football.Stats.Service.Models
{
    public class Match
    {
        [Key]
        public int Id { get; set; }
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public int HomeTeamGoals { get; set; }
        public int AwayTeamGoals { get; set; }

    }
}