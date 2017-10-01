using System;
using Newtonsoft.Json;

namespace xamarintraining
{
    public class User
    {
        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
