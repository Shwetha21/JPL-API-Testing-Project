namespace SentryAPI.SentrydesDataApiService.DataHandling
{
    public class HmaxRoot
    {
        public string count { get; set; }
        public Signature signature { get; set; }
        public Datum[] data { get; set; }
    }

    public class HmaxSignature
    {
        public string source { get; set; }
        public string version { get; set; }
    }

    public class HmaxDatum
    {
        public string ip { get; set; }
        public string range { get; set; }
        public string ps_cum { get; set; }
        public string diameter { get; set; }
        public string ps_max { get; set; }
        public string h { get; set; }
        public string last_obs { get; set; }
        public string v_inf { get; set; }
        public string fullname { get; set; }
        public string n_imp { get; set; }
        public string last_obs_jd { get; set; }
        public string ts_max { get; set; }
        public string id { get; set; }
        public string des { get; set; }
    }
}