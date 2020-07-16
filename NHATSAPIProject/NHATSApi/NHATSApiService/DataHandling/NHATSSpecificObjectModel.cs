namespace NHATSApi.NHATSApiService.DataHandling
{
    public class NHATSSpecificRoot
    {
        public string min_size { get; set; }
        public string occ { get; set; }
        public string n_via_traj { get; set; }
        public Min_Dv min_dv { get; set; }
        public Min_Dv_Traj min_dv_traj { get; set; }
        public string radar_snr_a { get; set; }
        public string obs_mag { get; set; }
        public string h { get; set; }
        public string orbit_id { get; set; }
        public string obs_flag { get; set; }
        public Min_Dur min_dur { get; set; }
        public string obs_end { get; set; }
        public string radar_snr_g { get; set; }
        public string radar_obs_a { get; set; }
        public string obs_start { get; set; }
        public string radar_obs_g { get; set; }
        public Min_Dur_Traj min_dur_traj { get; set; }
        public Signature signature { get; set; }
        public string computed { get; set; }
        public string fullname { get; set; }
        public string des { get; set; }
        public string max_size { get; set; }
    }

    public class Minimum_Dv
    {
        public string dv { get; set; }
        public string dur { get; set; }
    }

    public class Min_Dv_Traj
    {
        public string c3 { get; set; }
        public string vrel_arr_earth { get; set; }
        public string dur_total { get; set; }
        public string dv_total { get; set; }
        public string tid { get; set; }
        public string vrel_arr_neo { get; set; }
        public string v_dep_earth { get; set; }
        public string vrel_dep_neo { get; set; }
        public string dur_at { get; set; }
        public string launch { get; set; }
        public string dec_arr { get; set; }
        public string dv_dep_park { get; set; }
        public string dur_out { get; set; }
        public string dur_ret { get; set; }
        public string v_arr_earth { get; set; }
        public string dec_dep { get; set; }
    }

    public class Minimum_Dur
    {
        public string dv { get; set; }
        public string dur { get; set; }
    }

    public class Min_Dur_Traj
    {
        public string c3 { get; set; }
        public string vrel_arr_earth { get; set; }
        public string dur_total { get; set; }
        public string dv_total { get; set; }
        public string tid { get; set; }
        public string vrel_arr_neo { get; set; }
        public string v_dep_earth { get; set; }
        public string vrel_dep_neo { get; set; }
        public string dur_at { get; set; }
        public string launch { get; set; }
        public string dec_arr { get; set; }
        public string dv_dep_park { get; set; }
        public string dur_out { get; set; }
        public string dur_ret { get; set; }
        public string v_arr_earth { get; set; }
        public string dec_dep { get; set; }
    }

    public class Signatures
    {
        public string source { get; set; }
        public string version { get; set; }
    }
}