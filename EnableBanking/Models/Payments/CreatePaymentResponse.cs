using Newtonsoft.Json;

namespace EnableBanking.Models.Payments
{
    public class CreatePaymentResponse
    {
        [JsonProperty("payment_id")]
        public Guid? PaymentId { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("url")]
        public Uri? Url { get; set; }
    }
}
