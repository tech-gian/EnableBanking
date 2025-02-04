using Newtonsoft.Json;

namespace EnableBanking.Models.Sessions
{
    public class DeleteSessionRequest
    {
        [JsonProperty("session_id")]
        public Guid? SessionId { get; set; }
    }
}
