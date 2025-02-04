using Newtonsoft.Json;

namespace EnableBanking.Models.General
{
    public class GetASPSPsResponse
    {
        [JsonProperty("aspsps")]
        public Aspsp[]? Aspsps { get; set; }
    }

    public class Aspsp
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("logo")]
        public string? Logo { get; set; }

        [JsonProperty("psu_types")]
        public string[]? PsuTypes { get; set; }

        [JsonProperty("auth_methods")]
        public AuthMethod[]? AuthMethods { get; set; }

        [JsonProperty("maximum_consent_validity")]
        public int? MaximumConsentValidity { get; set; }

        [JsonProperty("sandbox")]
        public Sandbox? Sandbox { get; set; }

        [JsonProperty("beta")]
        public bool? Beta { get; set; }

        [JsonProperty("bic")]
        public string? Bic { get; set; }

        [JsonProperty("required_psu_headers")]
        public string[]? RequiredPsuHeaders { get; set; }

        [JsonProperty("payments")]
        public Payment[]? Payments { get; set; }
    }

    public class AuthMethod
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("psu_type")]
        public string? PsuType { get; set; }

        [JsonProperty("credentials")]
        public Credential[]? Credentials { get; set; }

        [JsonProperty("approach")]
        public string? Approach { get; set; }

        [JsonProperty("hidden_method")]
        public bool? HiddenMethod { get; set; }
    }

    public class Credential
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("required")]
        public bool? Required { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("template")]
        public string? Template { get; set; }
    }

    public class Sandbox
    {
        [JsonProperty("users")]
        public User[]? Users { get; set; }
    }

    public class User
    {
        [JsonProperty("username")]
        public string? Username { get; set; }

        [JsonProperty("password")]
        public string? Password { get; set; }

        [JsonProperty("otp")]
        public string? Otp { get; set; }
    }

    public class Payment
    {
        [JsonProperty("allowed_auth_methods")]
        public string[]? AllowedAuthMethods { get; set; }

        [JsonProperty("charge_bearer_values")]
        public string[]? ChargeBearerValues { get; set; }

        [JsonProperty("creditor_account_schemas")]
        public string[]? CreditorAccountSchemas { get; set; }

        [JsonProperty("creditor_agent_bic_fi_required")]
        public bool? CreditorAgentBicFiRequired { get; set; }

        [JsonProperty("creditor_agent_clearing_system_member_id_required")]
        public bool? CreditorAgentClearingSystemMemberIdRequired { get; set; }

        [JsonProperty("creditor_country_required")]
        public bool? CreditorCountryRequired { get; set; }

        [JsonProperty("creditor_name_required")]
        public bool? CreditorNameRequired { get; set; }

        [JsonProperty("creditor_postal_address_required")]
        public bool? CreditorPostalAddressRequired { get; set; }

        [JsonProperty("currencies")]
        public string[]? Currencies { get; set; }

        [JsonProperty("debtor_account_required")]
        public bool? DebtorAccountRequired { get; set; }

        [JsonProperty("debtor_account_schemas")]
        public string[]? DebtorAccountSchemas { get; set; }

        [JsonProperty("debtor_contact_email_required")]
        public bool? DebtorContactEmailRequired { get; set; }

        [JsonProperty("debtor_contact_phone_required")]
        public bool? DebtorContactPhoneRequired { get; set; }

        [JsonProperty("debtor_currency_required")]
        public bool? DebtorCurrencyRequired { get; set; }

        [JsonProperty("max_transactions")]
        public int? MaxTransactions { get; set; }

        [JsonProperty("payment_type")]
        public string? PaymentType { get; set; }

        [JsonProperty("priority_codes")]
        public string[]? PriorityCodes { get; set; }

        [JsonProperty("psu_type")]
        public string? PsuType { get; set; }

        [JsonProperty("reference_number_schemas")]
        public string[]? ReferenceNumberSchemas { get; set; }

        [JsonProperty("reference_number_supported")]
        public bool? ReferenceNumberSupported { get; set; }

        [JsonProperty("regulatory_reporting_code_required")]
        public bool? RegulatoryReportingCodeRequired { get; set; }

        [JsonProperty("remittance_information_lines")]
        public RemittanceInformationLine[]? RemittanceInformationLines { get; set; }

        [JsonProperty("remittance_information_required")]
        public bool? RemittanceInformationRequired { get; set; }

        [JsonProperty("requested_execution_date_max_period")]
        public int? RequestedExecutionDateMaxPeriod { get; set; }

        [JsonProperty("requested_execution_date_supported")]
        public bool? RequestedExecutionDateSupported { get; set; }
    }

    public class RemittanceInformationLine
    {
        [JsonProperty("max_length")]
        public int? MaxLength { get; set; }

        [JsonProperty("min_length")]
        public int? MinLength { get; set; }

        [JsonProperty("pattern")]
        public string? Pattern { get; set; }
    }
}
