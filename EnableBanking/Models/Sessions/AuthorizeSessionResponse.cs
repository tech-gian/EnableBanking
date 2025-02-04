using Newtonsoft.Json;

namespace EnableBanking.Models.Sessions
{
    public class AuthorizeSessionResponse
    {
        [JsonProperty("session_id")]
        public Guid? SessionId { get; set; }

        [JsonProperty("accounts")]
        public Account[]? Accounts { get; set; }

        [JsonProperty("aspsp")]
        public Aspsp? Aspsp { get; set; }

        [JsonProperty("psu_type")]
        public string? PsuType { get; set; }

        [JsonProperty("access")]
        public Access? Access { get; set; }
    }

    public class Account
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
        public AccountId[]? AllAccountIds { get; set; }

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
        public bool? LegalAge { get; set; }

        [JsonProperty("uid")]
        public Guid? Uid { get; set; }
    }

    public class AccountId
    {
        [JsonProperty("iban")]
        public string? Iban { get; set; }

        [JsonProperty("other")]
        public Other? Other { get; set; }
    }

    public class AccountServicer
    {
        [JsonProperty("bic_fi")]
        public string? BicFi { get; set; }

        [JsonProperty("clearing_system_member_id")]
        public ClearingSystemMemberId? ClearingSystemMemberId { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }
    }

    public class ClearingSystemMemberId
    {
        [JsonProperty("clearing_system_id")]
        public string? ClearingSystemId { get; set; }

        [JsonProperty("member_id")]
        public string? MemberId { get; set; }
    }

    public class CreditLimit
    {
        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("amount")]
        public string? Amount { get; set; }
    }
}
