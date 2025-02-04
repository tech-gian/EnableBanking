using Newtonsoft.Json;

namespace EnableBanking.Models.Payments
{
    public class CreatePaymentRequest
    {
        [JsonProperty("payment_type")]
        public string? PaymentType { get; set; }

        [JsonProperty("payment_request")]
        public PaymentRequestDetails? PaymentRequestDetails { get; set; }

        [JsonProperty("payment_information_id")]
        public string? PaymentInformationId { get; set; }

        [JsonProperty("payment_type_information")]
        public PaymentTypeInformation? PaymentTypeInformation { get; set; }

        [JsonProperty("debtor")]
        public Debtor? Debtor { get; set; }

        [JsonProperty("debtor_account")]
        public DebtorAccount? DebtorAccount { get; set; }

        [JsonProperty("debtor_agent")]
        public DebtorAgent? DebtorAgent { get; set; }

        [JsonProperty("debtor_currency")]
        public string? DebtorCurrency { get; set; }

        [JsonProperty("purpose")]
        public string? Purpose { get; set; }

        [JsonProperty("charge_bearer")]
        public string? ChargeBearer { get; set; }
    }

    public class PaymentRequestDetails
    {
        [JsonProperty("credit_transfer_transaction")]
        public CreditTransferTransaction[]? CreditTransferTransaction { get; set; }

        [JsonProperty("payment_type_information")]
        public PaymentTypeInformation? PaymentTypeInformation { get; set; }

        [JsonProperty("regulatory_reporting")]
        public RegulatoryReporting[]? RegulatoryReporting { get; set; }

        [JsonProperty("remittance_information")]
        public string[]? RemittanceInformation { get; set; }
    }

    public class UltimateDebtor
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("postal_address")]
        public PostalAddress? PostalAddress { get; set; }

        [JsonProperty("organisation_id")]
        public Identification? OrganisationId { get; set; }

        [JsonProperty("private_id")]
        public Identification? PrivateId { get; set; }

        [JsonProperty("contact_details")]
        public ContactDetails? ContactDetails { get; set; }
    }

    public class UltimateCreditor
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("postal_address")]
        public PostalAddress? PostalAddress { get; set; }

        [JsonProperty("organisation_id")]
        public Identification? OrganisationId { get; set; }

        [JsonProperty("private_id")]
        public Identification? PrivateId { get; set; }

        [JsonProperty("contact_details")]
        public ContactDetails? ContactDetails { get; set; }
    }

    public class SchemeName
    {
        [JsonProperty("value")]
        public string? Value { get; set; }
    }

    public class Issuer
    {
        [JsonProperty("value")]
        public string? Value { get; set; }
    }

    public class DebtorAccount
    {
        [JsonProperty("identification")]
        public string? Identification { get; set; }

        [JsonProperty("scheme_name")]
        public string? SchemeName { get; set; }

        [JsonProperty("issuer")]
        public string? Issuer { get; set; }
    }

    public class Aspsp
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }
    }

    public class PaymentState
    {
        [JsonProperty("state")]
        public string? State { get; set; }

        [JsonProperty("redirect_url")]
        public string? RedirectUrl { get; set; }

        [JsonProperty("psu_type")]
        public string? PsuType { get; set; }

        [JsonProperty("credentials")]
        public object? Credentials { get; set; }

        [JsonProperty("auth_method")]
        public string? AuthMethod { get; set; }

        [JsonProperty("language")]
        public string? Language { get; set; }

        [JsonProperty("webhook_url")]
        public string? WebhookUrl { get; set; }
    }
}
