using Newtonsoft.Json;

namespace EnableBanking.Models.General
{
    public class StartAuthorizationRequest
    {
        [JsonProperty("access")]
        public Access? Access { get; set; }

        [JsonProperty("aspsp")]
        public Aspsp? Aspsp { get; set; }

        [JsonProperty("state")]
        public string? State { get; set; }

        [JsonProperty("redirect_url")]
        public Uri? RedirectUrl { get; set; }

        [JsonProperty("psu_type")]
        public string? PsuType { get; set; }

        [JsonProperty("auth_method")]
        public string? AuthMethod { get; set; }

        [JsonProperty("credentials")]
        public object? Credentials { get; set; }

        [JsonProperty("credentials_autosubmit")]
        public bool? CredentialsAutosubmit { get; set; }

        [JsonProperty("language")]
        public string? Language { get; set; }

        [JsonProperty("psu_id")]
        public string? PsuId { get; set; }
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

    public class Account
    {
        [JsonProperty("iban")]
        public string? Iban { get; set; }

        [JsonProperty("other")]
        public Other? Other { get; set; }
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
