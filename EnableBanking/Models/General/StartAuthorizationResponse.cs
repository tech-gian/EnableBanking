using Newtonsoft.Json;

namespace EnableBanking.Models.General
{
    public class StartAuthorizationResponse
    {
        [JsonProperty("url")]
        public Uri? Url { get; set; }

        [JsonProperty("authorization_id")]
        public Guid? AuthorizationId { get; set; }

        [JsonProperty("psu_id_hash")]
        public string? PsuIdHash { get; set; }
    }
}
