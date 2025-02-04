using Newtonsoft.Json;

namespace EnableBanking.Models.Accounts
{
    public class GetTransactionRequest
    {
        [JsonProperty("account_id")]
        public Guid? AccountId { get; set; }

        [JsonProperty("transaction_id")]
        public string? TransactionId { get; set; }
    }
}
