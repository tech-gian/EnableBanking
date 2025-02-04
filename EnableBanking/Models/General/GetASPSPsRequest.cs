using Newtonsoft.Json;

namespace EnableBanking.Models.General
{
    public class GetASPSPsRequest
    {
        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("psu_type")]
        public string? PsuType { get; set; }

        [JsonProperty("service")]
        public string? Service { get; set; }

        [JsonProperty("payment_type")]
        public string? PaymentType { get; set; }
    }
}
