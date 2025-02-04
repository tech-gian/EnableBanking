using Newtonsoft.Json;

namespace EnableBanking.Models.Accounts
{
    public class GetTransactionsResponse
    {
        [JsonProperty("transactions")]
        public Transaction[]? Transactions { get; set; }

        [JsonProperty("continuationKey")]
        public string? ContinuationKey { get; set; }
    }

    public class TransactionAmount
    {
        [JsonProperty("amount")]
        public string? Amount { get; set; }

        [JsonProperty("currencyCode")]
        public string? CurrencyCode { get; set; }
    }

    public class RemittanceInformation
    {
        [JsonProperty("unstructuredArray")]
        public string[]? UnstructuredArray { get; set; }
    }

    public class TransactionBalance
    {
        [JsonProperty("amount")]
        public TransactionAmount? Amount { get; set; }

        [JsonProperty("creditDebitIndicator")]
        public string? CreditDebitIndicator { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }
    }
}
