namespace JPL_API_Testing.FireballAPI.FireballAPIService.DataHandling
{
    public class FireballModel
    {
        public Signature signature { get; set; }
        public string count { get; set; }
        public string[] fields { get; set; }
        public string[][] data { get; set; }
    }

    public class Signature
    {
        public string source { get; set; }
        public string version { get; set; }
    }
}
