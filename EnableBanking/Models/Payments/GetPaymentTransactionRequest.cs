using Newtonsoft.Json;

namespace EnableBanking.Models.Payments
{
    public class GetPaymentTransactionRequest
    {
        [JsonProperty("payment_id")]
        public string? PaymentId { get; set; }

        [JsonProperty("transaction_id")]
        public string? TransactionId { get; set; }
    }
}
