using System;
using System.Collections.Generic;

namespace Football.Stats.Contracts
{
    public class TeamDto
    {
        public List<string> _links { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ShortName { get; set; }
        public double SquadMarkedValue { get; set; }
        public LeagueDto League { get; set; }
    }
}
