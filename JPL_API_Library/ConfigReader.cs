
using System.Configuration;

namespace JPL_API_Library
{
    public class ConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
    }
}
