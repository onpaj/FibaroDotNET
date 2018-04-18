using System;
using System.IO;
using FibaroDotNetSDK.Infrastructure;
using Newtonsoft.Json;

namespace FibaroDotNet.Tests
{
    public static class TestHelper
    {
        public static HubSettings GetSettings()
        {
            var configFile = File.ReadAllText("localsecret.json");

            return JsonConvert.DeserializeObject<HubSettings>(configFile);
        }
    }
}
