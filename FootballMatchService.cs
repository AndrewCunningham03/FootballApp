using Newtonsoft.Json;
using RestSharp;

namespace FootballApp
{
    public class FootballMatchService : MatchInterface
    {
        public Matches? GetMatches()
        {
            var client = new RestClient("http://api.football-data.org/v4/matches");
            var request = new RestRequest();

            string apiKey = "999b81e4c85e46629a6c6b586ed9b788";
            string user = "test";
            string method = "user.getMatches";

            request.AddHeader("X-Auth-Token", apiKey);
            
            request.AddParameter("user", user);
            request.AddParameter("method", method);
            
            request.AddParameter("format", "json");

            var response = client.Get(request);
            if (!string.IsNullOrEmpty(response.Content))
            {
                string recievedJson = response.Content;
                Matches? matches = JsonConvert.DeserializeObject<Matches?>(recievedJson);
                return matches;
            }

            return null;
            

        }
    }
}
