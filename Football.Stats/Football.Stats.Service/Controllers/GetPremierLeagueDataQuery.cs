using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Football.Stats.Contracts;
using Football.Stats.Service.Infrastructure;

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
              
                var result = await client.GetAsync(string.Format("http://api.football-data.org/v1/competitions/?season={0}",Year));
                return result.Content.ToString();
            }
        }
    }
}