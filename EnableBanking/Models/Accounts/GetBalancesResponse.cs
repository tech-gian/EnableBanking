using Newtonsoft.Json;

namespace EnableBanking.Models.Accounts
{
    public class GetBalancesResponse
    {
        [JsonProperty("balances")]
        public Balance[]? Balances { get; set; }
    }

    public class Balance
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("balance_amount")]
        public BalanceAmount? BalanceAmount { get; set; }

        [JsonProperty("balance_type")]
        public string? BalanceType { get; set; }

        [JsonProperty("last_change_date_time")]
        public string? LastChangeDateTime { get; set; }

        [JsonProperty("reference_date")]
        public string? ReferenceDate { get; set; }

        [JsonProperty("last_committed_transaction")]
        public string? LastCommittedTransaction { get; set; }
    }

    public class BalanceAmount
    {
        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("amount")]
        public string? Amount { get; set; }
    }
}
