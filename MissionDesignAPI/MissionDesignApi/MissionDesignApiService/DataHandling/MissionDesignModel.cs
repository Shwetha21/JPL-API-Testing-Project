namespace MissionDesignApi.MissionDesignApiService.DataHandling
{
    public class MissionDesignRoot
    {
        public Signature signature { get; set; }
        public Object _object { get; set; }
        public Dv_Lowthrust dv_lowthrust { get; set; }
        public string[] fields { get; set; }
        public float[][] selectedMissions { get; set; }
    }

    public class Signature
    {
        public string source { get; set; }
        public string version { get; set; }
    }

    public class Object
    {
        public string data_arc { get; set; }
        public string md_orbit_id { get; set; }
        public string orbit_class { get; set; }
        public string spkid { get; set; }
        public string condition_code { get; set; }
        public string orbit_id { get; set; }
        public string fullname { get; set; }
        public string des { get; set; }
    }

    public class Dv_Lowthrust
    {
        public float sep { get; set; }
        public float _const { get; set; }
    }
}