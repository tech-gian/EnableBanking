using Newtonsoft.Json;

namespace EnableBanking.Models.Payments
{
    public class GetPaymentTransactionResponse
    {
        [JsonProperty("payment_id")]
        public string? PaymentId { get; set; }

        [JsonProperty("transaction_details")]
        public TransactionDetails? TransactionDetails { get; set; }

        [JsonProperty("payment_id")]
        public PaymentIdDetails? PaymentIdDetails { get; set; }

        [JsonProperty("requested_execution_date")]
        public string? RequestedExecutionDate { get; set; }

        [JsonProperty("reference_number")]
        public string? ReferenceNumber { get; set; }

        [JsonProperty("end_date")]
        public string? EndDate { get; set; }

        [JsonProperty("execution_rule")]
        public string? ExecutionRule { get; set; }

        [JsonProperty("frequency")]
        public string? Frequency { get; set; }

        [JsonProperty("ultimate_debtor")]
        public Debtor? UltimateDebtor { get; set; }

        [JsonProperty("ultimate_creditor")]
        public Creditor? UltimateCreditor { get; set; }

        [JsonProperty("regulatory_reporting")]
        public RegulatoryReporting[]? RegulatoryReporting { get; set; }

        [JsonProperty("remittance_information")]
        public string[]? RemittanceInformation { get; set; }

        [JsonProperty("transaction_id")]
        public string? TransactionId { get; set; }

        [JsonProperty("transaction_status")]
        public string? TransactionStatus { get; set; }
    }

    public class TransactionDetails
    {
        [JsonProperty("instructed_amount")]
        public InstructedAmount? InstructedAmount { get; set; }

        [JsonProperty("beneficiary")]
        public Beneficiary? Beneficiary { get; set; }

        [JsonProperty("creditor_currency")]
        public string? CreditorCurrency { get; set; }
    }

    public class InstructedAmount
    {
        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("amount")]
        public string? Amount { get; set; }
    }

    public class CreditorAccount
    {
        [JsonProperty("identification")]
        public string? Identification { get; set; }

        [JsonProperty("scheme_name")]
        public string? SchemeName { get; set; }

        [JsonProperty("issuer")]
        public string? Issuer { get; set; }
    }

    public class CreditorAgent
    {
        [JsonProperty("bic_fi")]
        public string? BicFi { get; set; }

        [JsonProperty("clearing_system_member_id")]
        public ClearingSystemMemberId? ClearingSystemMemberId { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }
    }

    public class Creditor
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("postal_address")]
        public PostalAddress? PostalAddress { get; set; }

        [JsonProperty("organisation_id")]
        public OrganisationId? OrganisationId { get; set; }

        [JsonProperty("private_id")]
        public PrivateId? PrivateId { get; set; }

        [JsonProperty("contact_details")]
        public ContactDetails? ContactDetails { get; set; }
    }

    public class AddressLine
    {
        [JsonProperty("value")]
        public string? Value { get; set; }
    }

    public class AddressType
    {
        [JsonProperty("value")]
        public string? Value { get; set; }
    }

    public class OrganisationId
    {
        [JsonProperty("identification")]
        public string? Identification { get; set; }

        [JsonProperty("scheme_name")]
        public string? SchemeName { get; set; }

        [JsonProperty("issuer")]
        public string? Issuer { get; set; }
    }

    public class PrivateId
    {
        [JsonProperty("identification")]
        public string? Identification { get; set; }

        [JsonProperty("scheme_name")]
        public string? SchemeName { get; set; }

        [JsonProperty("issuer")]
        public string? Issuer { get; set; }
    }

    public class ReportingDetails
    {
        [JsonProperty("information")]
        public string? Information { get; set; }

        [JsonProperty("amount")]
        public Amount? Amount { get; set; }

        [JsonProperty("code")]
        public string? Code { get; set; }
    }

    public class Currency
    {
        [JsonProperty("value")]
        public string? Value { get; set; }
    }

    public class Authority
    {
        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }
    }

    public class PaymentIdDetails
    {
        [JsonProperty("instruction_id")]
        public string? InstructionId { get; set; }

        [JsonProperty("end_to_end_id")]
        public string? EndToEndId { get; set; }
    }
}
