using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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