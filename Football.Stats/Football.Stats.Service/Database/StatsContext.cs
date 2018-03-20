using System.Data.Entity;
using Football.Stats.Service.Models;
using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace Football.Stats.Service.Database
{
    public interface IStatsContext
    {
        IDbSet<League> Leagues { get; }
        IDbSet<Match> Matches { get; }
        IDbSet<MatchDay> MatchDays { get; }
        IDbSet<Team> Teams { get; }
    }
    public class StatsContext : IStatsContext, DbContext
    {
        public StatsContext(DbContextOptions<StatsContext> options)
            : base(options)
        { }
 
        public IDbSet<League> Leagues => throw new System.NotImplementedException();

        public IDbSet<Match> Matches => throw new System.NotImplementedException();

        public IDbSet<MatchDay> MatchDays => throw new System.NotImplementedException();

        public IDbSet<Team> Teams => throw new System.NotImplementedException();
    }
}

public class BloggingContext : DbContext
{
    public BloggingContext(DbContextOptions<BloggingContext> options)
        : base(options)
    { }

    public Microsoft.EntityFrameworkCore.DbSet<Blog> Blogs { get; set; }
    public Microsoft.EntityFrameworkCore.DbSet<Post> Posts { get; set; }
}