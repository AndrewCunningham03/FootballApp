

    public class Team
    {
        public Area1 area { get; set; }
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
        public int marketValue { get; set; }
        public Squad[] squad { get; set; }
        public Staff[] staff { get; set; }
        public DateTime lastUpdated { get; set; }
    }

    public class Area1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string flag { get; set; }
    }

    public class Coach
    {
        public int id { get; set; }
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
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public string dateOfBirth { get; set; }
        public string nationality { get; set; }
        public int shirtNumber { get; set; }
        public int? marketValue { get; set; }
        public Contract1 contract { get; set; }
    }

    public class Contract1
    {
        public string start { get; set; }
        public string until { get; set; }
    }

    public class Staff
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string name { get; set; }
        public string dateOfBirth { get; set; }
        public string nationality { get; set; }
        public Contract2 contract { get; set; }
    }

    public class Contract2
    {
        public string start { get; set; }
        public string until { get; set; }
    }


