using AutoMapper;
using Football.Stats.Contracts;
using Football.Stats.Service.Models;

namespace Football.Stats.Service.Infrastructure
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(ctx =>
            {
                ctx.CreateMap<League, LeagueDto>();
                ctx.CreateMap<LeagueDto, League>();

                ctx.CreateMap<Team, TeamDto>();
                ctx.CreateMap<TeamDto, Team>();
            });
        }
    }
}