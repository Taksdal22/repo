﻿namespace Football.Stats.Contracts
{
    public class LeagueDto
    {
        public int Id { get; set; }
        public string Caption { get; set; }

        public string League { get; set; }
        public int Year { get; set; }

        public int NumberOfMatchdays { get; set; }
        public int CurrentMatchday  { get; set; }
        public int NumberOfTeams { get; set; }
        public int NumberOfGames { get; set; }

    }
}