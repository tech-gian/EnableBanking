using Newtonsoft.Json;

namespace EnableBanking.Models.Payments
{
    public class GetPaymentRequest
    {
        [JsonProperty("payment_id")]
        public string? PaymentId { get; set; }
    }
}
