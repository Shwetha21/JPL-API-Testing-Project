namespace JPL_API_Testing.FireballApi.FireballAPIService.DataHandling
{
    public class FireballKeyValues
    {
        public string Date { get; set; }
        public string Energy { get; set; }
        public string Impacte { get; set; }
        public string Lat { get; set; }
        public string Latdir { get; set; }
        public string Lon { get; set; }
        public string Londir { get; set; }
        public string Alt { get; set; }
        public string Vel { get; set; }

        public FireballKeyValues(string date, string energy, string impacte, string lat, string latdir, string lon, string londir, string alt, string vel)
        {
            Date = date;
            Energy = energy;
            Impacte = impacte;
            Lat = lat;
            Latdir = latdir;
            Lon = lon;
            Londir = londir;
            Alt = alt;
            Vel = vel;
        }
    }
}