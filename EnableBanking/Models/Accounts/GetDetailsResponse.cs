using EnableBanking.Models.Sessions;
using Newtonsoft.Json;

namespace EnableBanking.Models.Accounts
{
    public class GetDetailsResponse
    {
        [JsonProperty("cash_account_type")]
        public string? CashAccountType { get; set; }

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("identification_hash")]
        public string? IdentificationHash { get; set; }

        [JsonProperty("identification_hashes")]
        public string[]? IdentificationHashes { get; set; }

        [JsonProperty("account_id")]
        public AccountId? AccountId { get; set; }

        [JsonProperty("all_account_ids")]
        public AllAccountId[]? AllAccountIds { get; set; }

        [JsonProperty("account_servicer")]
        public AccountServicer? AccountServicer { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("details")]
        public string? Details { get; set; }

        [JsonProperty("usage")]
        public string? Usage { get; set; }

        [JsonProperty("product")]
        public string? Product { get; set; }

        [JsonProperty("psu_status")]
        public string? PsuStatus { get; set; }

        [JsonProperty("credit_limit")]
        public CreditLimit? CreditLimit { get; set; }

        [JsonProperty("legal_age")]
        public string? LegalAge { get; set; }

        [JsonProperty("uid")]
        public string? Uid { get; set; }
    }

    public class AllAccountId
    {
        [JsonProperty("identification")]
        public string? Identification { get; set; }

        [JsonProperty("scheme_name")]
        public string? SchemeName { get; set; }

        [JsonProperty("issuer")]
        public string? Issuer { get; set; }
    }
}
