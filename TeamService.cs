﻿using Newtonsoft.Json;
using RestSharp;

namespace FootballApp
{
    public class TeamService : TeamInterface
    {

        public Team? GetAllTeamsInPL()
        {
            var client = new RestClient("http://api.football-data.org/v4/competitions/PL/teams");
            var request = new RestRequest();

            string apiKey = "999b81e4c85e46629a6c6b586ed9b788";
            string user = "test";   
            string method = "user.getTeam";

            request.AddHeader("X-Auth-Token", apiKey);

            request.AddParameter("user", user);
            request.AddParameter("method", method);
            request.AddParameter("format", "json");

            var response = client.Get(request);
            if (!string.IsNullOrEmpty(response.Content))
            {
                string recievedJson = response.Content;
                Team? teams = JsonConvert.DeserializeObject<Team?>(recievedJson);
                return teams;
            }

            return null;
           

        }

        /*
        public Team? GetTeam(int teamID)
        {
            var client = new RestClient("http://api.football-data.org/v4/teams/{teamID}");
            var request = new RestRequest();

            string apiKey = "999b81e4c85e46629a6c6b586ed9b788";
            string user = "test";
            string method = "user.getTeam";

            request.AddHeader("X-Auth-Token", apiKey);
            //request.AddParameter("id", teamID);

            request.AddParameter("user", user);
            request.AddParameter("method", method);
            //request.AddParameter("limit", 10);
            request.AddParameter("format", "json");

            var response = client.Execute(request);
            if (!string.IsNullOrEmpty(response.Content))
            {
                string recievedJson = response.Content;
                Team? team = JsonConvert.DeserializeObject<Team?>(recievedJson);
                return team;
            }

            return null;
            

        }
        */
       
    }
}
