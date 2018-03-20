using System;
using System.Collections.Generic;

namespace Football.Stats.Service.Models
{
    public class MatchDay
    {
        public int Id { get; set; }
        public League League { get; set; }
        public List<Match> Match { get; set; }
    }
}
