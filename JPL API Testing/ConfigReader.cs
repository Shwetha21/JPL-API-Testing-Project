
using System.Configuration;

namespace JPL_API_Testing
{
    public class ConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
    }
}
