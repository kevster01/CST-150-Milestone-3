using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CST_Project_1
{
    public partial class Config
    {
        [JsonProperty("server")]
        public string Server { get; set; }

        [JsonProperty("port")]
        public long Port { get; set; }

        [JsonProperty("database")]
        public string Database { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }

    public partial class Config
    {
        private static Config FromJson(string json) => JsonConvert.DeserializeObject<Config>(json, CST_Project_1.Converter.Settings);
        public static Config Load(string filename)
        {
            if (!File.Exists(filename)) {
                new Config().Save(filename);
            }

            string json = File.ReadAllText(filename);
            return FromJson(json);
        }

        public void Save(string filename) {
            File.WriteAllText(filename, this.ToJson());
        }
    }

    public static class Serialize
    {
        public static string ToJson(this Config self) => JsonConvert.SerializeObject(self, CST_Project_1.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
