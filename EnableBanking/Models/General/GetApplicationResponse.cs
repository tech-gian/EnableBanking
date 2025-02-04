using Newtonsoft.Json;

namespace EnableBanking.Models.General
{
    public class GetApplicationResponse
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("kid")]
        public Guid? Kid { get; set; }

        [JsonProperty("environment")]
        public string? Environment { get; set; }

        [JsonProperty("redirect_urls")]
        public Uri[]? RedirectUrls { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("countries")]
        public string[]? Countries { get; set; }

        [JsonProperty("services")]
        public string[]? Services { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }
    }
}
