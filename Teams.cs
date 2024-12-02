namespace FootballApp
{

    public class Teams
    {
        public int count { get; set; }
        public Filters filters { get; set; }
        public Competition competition { get; set; }
        public Season season { get; set; }
        public Team[] teams { get; set; }

        public static implicit operator Teams(Team v)
        {
            throw new NotImplementedException();
        }
    }

    public class Filters
    {
        public string season { get; set; }
    }

    public class Competition
    {
        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public string emblem { get; set; }
    }

    public class Season
    {
        public int id { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public int currentMatchday { get; set; }
        public object winner { get; set; }
    }

    public class Team
    {
        public Area area { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string shortName { get; set; }
        public string tla { get; set; }
        public string crest { get; set; }
        public string address { get; set; }
        public string website { get; set; }
        public int founded { get; set; }
        public string clubColors { get; set; }
        public string venue { get; set; }
        public Runningcompetition[] runningCompetitions { get; set; }
        public Coach coach { get; set; }
        public Squad[] squad { get; set; }
        public object[] staff { get; set; }
        public DateTime lastUpdated { get; set; }
        public Team(Area area, int id, string name, string shortName, string tla, string crest, string address, string website, int founded, string clubColors, string venue, Runningcompetition[] runningCompetitions, Coach coach, Squad[] squad, object[] staff, DateTime lastUpdated)
        {
            this.area = area;
            this.id = id;
            this.name = name;
            this.shortName = shortName;
            this.tla = tla;
            this.crest = crest;
            this.address = address;
            this.website = website;
            this.founded = founded;
            this.clubColors = clubColors;
            this.venue = venue;
            this.runningCompetitions = runningCompetitions;
            this.coach = coach;
            this.squad = squad;
            this.staff = staff;
            this.lastUpdated = lastUpdated;
        }

        public Team(int id)
        {
            if(id > 0) {  this.id = id; } else { this.id = -1; }

        }
        public Team()
        {

        }
        public override bool Equals(object? obj)
        {
            return obj is Team team &&
                   id == team.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }
    }

    public class Area
    {
        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string flag { get; set; }
    }

    public class Coach
    {
        public int? id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string name { get; set; }
        public string dateOfBirth { get; set; }
        public string nationality { get; set; }
        public Contract contract { get; set; }
    }

    public class Contract
    {
        public string start { get; set; }
        public string until { get; set; }
    }

    public class Runningcompetition
    {
        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public string emblem { get; set; }
    }

    public class Squad
    {
        public int id { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public string dateOfBirth { get; set; }
        public string nationality { get; set; }
    }

}
