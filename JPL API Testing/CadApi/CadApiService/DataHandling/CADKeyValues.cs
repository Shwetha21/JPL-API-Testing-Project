using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPL_API_Testing.CadApi.CadApiService.DataHandling
{
    public class CADKeyValues
    {
        public string des { get; set; }
        public string orbit_id { get; set; }
        public string jd { get; set; }
        public string cd { get; set; }
        public string dist { get; set; }
        public string dist_min { get; set; }
        public string dist_max { get; set; }
        public string v_rel { get; set; }
        public string v_inf { get; set; }
        public string t_sigma_f { get; set; }
        public string h { get; set; }

        public CADKeyValues(string Des, string Orbit_Id, string Jd, string Cd, string Dist, string Dist_min, string Dist_max, string V_rel, string V_inf, string T_sigma_f, string H)
        {
            des = Des;
            orbit_id = Orbit_Id;
            jd = Jd;
            cd = Cd;
            dist = Dist;
            dist_min = Dist_min;
            dist_max = Dist_max;
            v_rel = V_rel;
            v_inf = V_inf;
            t_sigma_f = T_sigma_f;
            h = H;
        }
    }
}
