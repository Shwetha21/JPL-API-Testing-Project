namespace MissionDesignApi.MissionDesignApiService.DataHandling
{
    public class MissionDesignKeyValues
    {
        public float MJD0 { get; set; }
        public float MJDf { get; set; }
        public float vinf_dep { get; set; }
        public float vinf_arr { get; set; }
        public float phase_ang { get; set; }
        public float earth_dist { get; set; }
        public float elong_arr { get; set; }
        public float decl_dep { get; set; }
        public float approach_ang { get; set; }
        public float tof { get; set; }

        public MissionDesignKeyValues(float mjdo, float mjdf, float vinfDep, float vinfArr, float phaseAng, float earthDist, float elongArr, float declDep, float approachAng, float Tof)
        {
            MJD0 = mjdo;
            MJDf = mjdf;
            vinf_dep = vinfDep;
            vinf_arr = vinfArr;
            phase_ang = phaseAng;
            earth_dist = earthDist;
            elong_arr = elongArr;
            decl_dep = declDep;
            approach_ang = approachAng;
            tof = Tof;
        }
    }
}