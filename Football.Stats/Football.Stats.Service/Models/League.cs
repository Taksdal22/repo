namespace Football.Stats.Service.Models
{
    public class League
    {
        public int Id { get; set; }
        public string Caption { get; set; }

        public string LeagueName { get; set; }
        public int Year { get; set; }

        public int NumberOfMatchdays { get; set; }
        public int CurrentMatchday  { get; set; }
        public int NumberOfTeams { get; set; }
        public int NumberOfGames { get; set; }

    }
}