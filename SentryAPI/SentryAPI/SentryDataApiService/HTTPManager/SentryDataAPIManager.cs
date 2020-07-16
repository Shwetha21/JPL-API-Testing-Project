﻿using RestSharp;
using JPL_API_Library;

namespace JPL_API_Testing.SentryAPI.SentrydesDataApiService.HTTPManager
{
    public class SentryAPIManager
    {
        private readonly IRestClient client;

        public SentryAPIManager()
        {
            client = new RestClient(ConfigReader.BaseUrl);
        }

        public string GetSentryData()
        {
            var request = new RestRequest("sentry.api", Method.GET);
            var response = client.Execute(request);
            return response.Content;
        }

        public string GetSentryData(int spk)
        {
            var request = new RestRequest($"sentry.api?spk={spk}", Method.GET);
            var response = client.Execute(request);
            return response.Content;
        }

        public string GetSentrydesData(int des)
        {
            var request = new RestRequest($"sentry.api?des={des}", Method.GET);
            var response = client.Execute(request);
            return response.Content;
        }

        public string GetSentryHmaxData(int hMax)
        {
            var request = new RestRequest($"sentry.api?h-max={hMax}", Method.GET);
            var response = client.Execute(request);
            return response.Content;
        }
    }
}