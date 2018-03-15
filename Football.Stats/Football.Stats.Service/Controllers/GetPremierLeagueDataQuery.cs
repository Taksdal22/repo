using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Football.Stats.Contracts;
using Football.Stats.Service.Infrastructure;
using Football.Stats.Service.Models;
using Newtonsoft.Json;
using System.Linq;

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
                var tmp = JsonConvert.DeserializeObject<List<LeagueDto>>(json);
                var premierLeague = tmp.SingleOrDefault(x => x.League == "PL");

                return json;
            }
        }
    }
}