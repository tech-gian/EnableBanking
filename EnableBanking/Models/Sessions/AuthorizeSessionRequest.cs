using Newtonsoft.Json;

namespace EnableBanking.Models.Sessions
{
    public class AuthorizeSessionRequest
    {
        [JsonProperty("code")]
        public string? Code { get; set; }
    }
}
