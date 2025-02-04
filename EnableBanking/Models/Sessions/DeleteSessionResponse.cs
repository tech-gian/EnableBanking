using Newtonsoft.Json;

namespace EnableBanking.Models.Sessions
{
    public class DeleteSessionResponse
    {
        [JsonProperty("message")]
        public string? Message { get; set; }
    }
}
