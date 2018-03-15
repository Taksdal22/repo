using System;
namespace Football.Stats.Service.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ShortName { get; set; }
        public double SquadMarkedValue { get; set; }
        public League League { get; set; }
    }
}
