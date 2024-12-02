


public class Matches
{
    public Filters filters { get; set; }
    public Resultset resultSet { get; set; }
    public Match[] matches { get; set; }
}

public class Filters
{
    public string dateFrom { get; set; }
    public string dateTo { get; set; }
    public string permission { get; set; }
}

public class Resultset
{
    public int count { get; set; }
    public string competitions { get; set; }
    public string first { get; set; }
    public string last { get; set; }
    public int played { get; set; }
}

public class Match
{
    public Match(Area area, Competition competition, Season season, int id, DateTime utcDate, string status, int matchday, string stage, object group, DateTime lastUpdated, Hometeam homeTeam, Awayteam awayTeam, Score score, Odds odds, object[] referees)
    {
        this.area = area;
        this.competition = competition;
        this.season = season;
        this.id = id;
        this.utcDate = utcDate;
        this.status = status;
        this.matchday = matchday;
        this.stage = stage;
        this.group = group;
        this.lastUpdated = lastUpdated;
        this.homeTeam = homeTeam;
        this.awayTeam = awayTeam;
        this.score = score;
        this.odds = odds;
        this.referees = referees;
    }

    public Match(Competition competition, int id, DateTime utcDate, Hometeam homeTeam, Awayteam awayTeam)
    {
        this.competition = competition;
        this.id = id;
        this.utcDate = utcDate;
        this.homeTeam = homeTeam;
        this.awayTeam = awayTeam;
    }
    public Match()
    {

    }

    public Area area { get; set; }
    public Competition competition { get; set; }
    public Season season { get; set; }
    public int id { get; set; }
    public DateTime utcDate { get; set; }
    public string status { get; set; }
    public int matchday { get; set; }
    public string stage { get; set; }
    public object group { get; set; }
    public DateTime lastUpdated { get; set; }
    public Hometeam homeTeam { get; set; }
    public Awayteam awayTeam { get; set; }
    public Score score { get; set; }
    public Odds odds { get; set; }
    public object[] referees { get; set; }

    public override bool Equals(object? obj)
    {
        return obj is Match match &&
               EqualityComparer<Competition>.Default.Equals(competition, match.competition) &&
               id == match.id &&
               utcDate == match.utcDate &&
               EqualityComparer<Hometeam>.Default.Equals(homeTeam, match.homeTeam) &&
               EqualityComparer<Awayteam>.Default.Equals(awayTeam, match.awayTeam);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(competition, id, utcDate, homeTeam, awayTeam);
    }
}

public class Area
{
    public int id { get; set; }
    public string name { get; set; }
    public string code { get; set; }
    public string flag { get; set; }
}

public class Competition
{
    public int id { get; set; }
    public string name { get; set; }
    public string code { get; set; }
    public string type { get; set; }
    public string emblem { get; set; }

    public Competition(int id, string name) { 
    
        this.id = id;
        this.name = name;
    }
}

public class Season
{
    public int id { get; set; }
    public string startDate { get; set; }
    public string endDate { get; set; }
    public int currentMatchday { get; set; }
    public object winner { get; set; }
}

public class Hometeam
{
    public int id { get; set; }
    public string name { get; set; }
    public string shortName { get; set; }
    public string tla { get; set; }
    public string crest { get; set; }

    public Hometeam(int id, String name)
    {
        this.id = id;
        this.name = name;
    }
}

public class Awayteam
{
    public int id { get; set; }
    public string name { get; set; }
    public string shortName { get; set; }
    public string tla { get; set; }
    public string crest { get; set; }

    public Awayteam(int id, string name)
    {
        this.id=id;
        this.name = name;
    }
}

public class Score
{
    public object winner { get; set; }
    public string duration { get; set; }
    public Fulltime fullTime { get; set; }
    public Halftime halfTime { get; set; }
}

public class Fulltime
{
    public object home { get; set; }
    public object away { get; set; }
}

public class Halftime
{
    public object home { get; set; }
    public object away { get; set; }
}

public class Odds
{
    public string msg { get; set; }
}
