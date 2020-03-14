using System.IO;
using System.Text.Json;

namespace SchoolBoard
{
    public static class Configuration
    {
        // Load config from disk
        public static Config Load()
        {
            string data = File.ReadAllText("config.json");
            Config config = JsonSerializer.Deserialize<Config>(data);
            return config;
        }

        // Save config to disk
        public static void Save(Config config)
        {
            string data = JsonSerializer.Serialize<Config>(config);
            File.WriteAllText("config.json", data);
        }
    }

}