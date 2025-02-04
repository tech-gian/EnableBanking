using Newtonsoft.Json;

namespace EnableBanking.Models.Sessions
{
    public class GetSessionResponse
    {
        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("accounts")]
        public Guid[]? Accounts { get; set; }

        [JsonProperty("accounts_data")]
        public AccountData[]? AccountsData { get; set; }

        [JsonProperty("aspsp")]
        public Aspsp? Aspsp { get; set; }

        [JsonProperty("psu_type")]
        public string? PsuType { get; set; }

        [JsonProperty("psu_id_hash")]
        public string? PsuIdHash { get; set; }

        [JsonProperty("access")]
        public Access? Access { get; set; }

        [JsonProperty("created")]
        public DateTime? Created { get; set; }

        [JsonProperty("authorized")]
        public DateTime? Authorized { get; set; }

        [JsonProperty("closed")]
        public DateTime? Closed { get; set; }
    }

    public class AccountData
    {
        [JsonProperty("uid")]
        public Guid? Uid { get; set; }

        [JsonProperty("identification_hash")]
        public string? IdentificationHash { get; set; }

        [JsonProperty("identification_hashes")]
        public string[]? IdentificationHashes { get; set; }
    }

    public class Aspsp
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }
    }

    public class Access
    {
        [JsonProperty("valid_until")]
        public DateTime? ValidUntil { get; set; }

        [JsonProperty("accounts")]
        public Account[]? Accounts { get; set; }

        [JsonProperty("balances")]
        public bool? Balances { get; set; }

        [JsonProperty("transactions")]
        public bool? Transactions { get; set; }
    }

    public class Other
    {
        [JsonProperty("identification")]
        public string? Identification { get; set; }

        [JsonProperty("scheme_name")]
        public string? SchemeName { get; set; }

        [JsonProperty("issuer")]
        public string? Issuer { get; set; }
    }
}
