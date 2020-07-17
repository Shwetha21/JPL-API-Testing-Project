namespace NHATSApi.NHATSApiService.DataHandling
{
    public class NHATSRoot
    {
        public string count { get; set; }
        public Signature signature { get; set; }
        public Datum[] data { get; set; }
    }

    public class Signature
    {
        public string source { get; set; }
        public string version { get; set; }
    }

    public class Datum
    {
        public string min_size { get; set; }
        public string occ { get; set; }
        public string n_via_traj { get; set; }
        public Min_Dv min_dv { get; set; }
        public float size { get; set; }
        public string radar_snr_a { get; set; }
        public string obs_mag { get; set; }
        public string orbit_id { get; set; }
        public string h { get; set; }
        public string obs_flag { get; set; }
        public string obs_end { get; set; }
        public Min_Dur min_dur { get; set; }
        public string radar_snr_g { get; set; }
        public string radar_obs_a { get; set; }
        public string obs_start { get; set; }
        public string radar_obs_g { get; set; }
        public string fullname { get; set; }
        public string des { get; set; }
        public string max_size { get; set; }
        public float size_sigma { get; set; }
    }

    public class Min_Dv
    {
        public string dv { get; set; }
        public string dur { get; set; }
    }

    public class Min_Dur
    {
        public string dv { get; set; }
        public string dur { get; set; }
    }
}