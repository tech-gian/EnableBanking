using Newtonsoft.Json;

namespace EnableBanking.Models.Accounts
{
    public class GetTransactionsRequest
    {
        [JsonProperty("account_id")]
        public Guid? AccountId { get; set; }

        [JsonProperty("date_from")]
        public DateTime? DateFrom { get; set; }

        [JsonProperty("date_to")]
        public DateTime? DateTo { get; set; }

        [JsonProperty("continuation_key")]
        public string? ContinuationKey { get; set; }

        [JsonProperty("transaction_status")]
        public string? TransactionStatus { get; set; }

        [JsonProperty("strategy")]
        public object? Strategy { get; set; }

    }
}
