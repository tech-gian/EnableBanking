using Newtonsoft.Json;

namespace EnableBanking.Models.Sessions
{
    public class GetSessionRequest
    {
        [JsonProperty("session_id")]
        public Guid? SessionId { get; set; }
    }
}
