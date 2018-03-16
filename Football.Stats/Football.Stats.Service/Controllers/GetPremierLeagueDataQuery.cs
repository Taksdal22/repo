using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Football.Stats.Contracts;
using Football.Stats.Service.Infrastructure;
using Football.Stats.Service.Models;
using Newtonsoft.Json;
using System.Linq;
using AutoMapper;

namespace Football.Stats.Service.Controllers
{
    public class GetPremierLeagueDataQuery 
    {

        public int Year { get; set; }
        public GetPremierLeagueDataQuery(int year)
        {
            Year = year;
        }
        public async Task<string> Handle()
        {
            using (var client = new HttpClient())
            {
                var json = await client.GetStringAsync(string.Format("http://api.football-data.org/v1/competitions/?season={0}",Year));
                var league = JsonConvert.DeserializeObject<List<LeagueDto>>(json).SingleOrDefault(x => x.League =="PL");
                var pl = Mapper.Map<LeagueDto, League>(league);
                return json;
            }
        }
    }
}