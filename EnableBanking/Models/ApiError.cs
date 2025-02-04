using Newtonsoft.Json;

namespace EnableBanking.Models
{
    public class ApiError
    {
        [JsonProperty("message")]
        public string? Message { get; set; }

        [JsonProperty("code")]
        public string? Code { get; set; }

        [JsonProperty("error")]
        public string? Error { get; set; }

        [JsonProperty("detail")]
        public object? Detail { get; set; }
    }
}
