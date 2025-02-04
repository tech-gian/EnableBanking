using Newtonsoft.Json;

namespace EnableBanking.Models.Payments
{
    public class GetPaymentResponse
    {
        [JsonProperty("payment_id")]
        public string? PaymentId { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("payment_details")]
        public PaymentDetails? PaymentDetails { get; set; }

        [JsonProperty("debtor")]
        public Debtor? Debtor { get; set; }

        [JsonProperty("debtor_account")]
        public Account? DebtorAccount { get; set; }

        [JsonProperty("debtor_agent")]
        public DebtorAgent? DebtorAgent { get; set; }

        [JsonProperty("debtor_currency")]
        public string? DebtorCurrency { get; set; }

        [JsonProperty("purpose")]
        public string? Purpose { get; set; }

        [JsonProperty("charge_bearer")]
        public string? ChargeBearer { get; set; }

        [JsonProperty("credit_transfer_transaction")]
        public CreditTransferTransaction[]? CreditTransferTransaction { get; set; }

        [JsonProperty("transaction_id")]
        public string? TransactionId { get; set; }

        [JsonProperty("transaction_status")]
        public string? TransactionStatus { get; set; }
    }

    public class PaymentDetails
    {
        [JsonProperty("payment_information_id")]
        public string? PaymentInformationId { get; set; }

        [JsonProperty("payment_type_information")]
        public PaymentTypeInformation? PaymentTypeInformation { get; set; }
    }

    public class PaymentTypeInformation
    {
        [JsonProperty("instruction_priority")]
        public string? InstructionPriority { get; set; }

        [JsonProperty("service_level")]
        public string? ServiceLevel { get; set; }

        [JsonProperty("category_purpose")]
        public string? CategoryPurpose { get; set; }

        [JsonProperty("local_instrument")]
        public string? LocalInstrument { get; set; }
    }

    public class Debtor
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

    public class PostalAddress
    {
        [JsonProperty("address_type")]
        public string? AddressType { get; set; }

        [JsonProperty("department")]
        public string? Department { get; set; }

        [JsonProperty("sub_department")]
        public string? SubDepartment { get; set; }

        [JsonProperty("street_name")]
        public string? StreetName { get; set; }

        [JsonProperty("building_number")]
        public string? BuildingNumber { get; set; }

        [JsonProperty("post_code")]
        public string? PostCode { get; set; }

        [JsonProperty("town_name")]
        public string? TownName { get; set; }

        [JsonProperty("country_sub_division")]
        public string? CountrySubDivision { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("address_line")]
        public string[]? AddressLine { get; set; }
    }

    public class ContactDetails
    {
        [JsonProperty("email_address")]
        public string? EmailAddress { get; set; }

        [JsonProperty("phone_number")]
        public string? PhoneNumber { get; set; }
    }

    public class Identification
    {
        [JsonProperty("identification")]
        public string? IdentificationValue { get; set; }

        [JsonProperty("scheme_name")]
        public string? SchemeName { get; set; }

        [JsonProperty("issuer")]
        public string? Issuer { get; set; }

        [JsonProperty("value")]
        public string? Value { get; set; }
    }

    public class Account
    {
        [JsonProperty("identification")]
        public string? Identification { get; set; }

        [JsonProperty("scheme_name")]
        public string? SchemeName { get; set; }

        [JsonProperty("issuer")]
        public string? Issuer { get; set; }
    }

    public class DebtorAgent
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

    public class CreditTransferTransaction
    {
        [JsonProperty("instructed_amount")]
        public Amount? InstructedAmount { get; set; }

        [JsonProperty("beneficiary")]
        public Beneficiary? Beneficiary { get; set; }

        [JsonProperty("payment_id")]
        public PaymentId? PaymentId { get; set; }

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
        public Debtor? UltimateCreditor { get; set; }

        [JsonProperty("regulatory_reporting")]
        public RegulatoryReporting[]? RegulatoryReporting { get; set; }

        [JsonProperty("remittance_information")]
        public string[]? RemittanceInformation { get; set; }
    }

    public class Amount
    {
        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("amount")]
        public string? AmountValue { get; set; }
    }

    public class Beneficiary
    {
        [JsonProperty("creditor_account")]
        public Account? CreditorAccount { get; set; }

        [JsonProperty("creditor_agent")]
        public DebtorAgent? CreditorAgent { get; set; }

        [JsonProperty("creditor")]
        public Debtor? Creditor { get; set; }

        [JsonProperty("creditor_currency")]
        public string? CreditorCurrency { get; set; }
    }

    public class PaymentId
    {
        [JsonProperty("instruction_id")]
        public string? InstructionId { get; set; }

        [JsonProperty("end_to_end_id")]
        public string? EndToEndId { get; set; }
    }

    public class RegulatoryReporting
    {
        [JsonProperty("details")]
        public string? Details { get; set; }

        [JsonProperty("authority")]
        public string? Authority { get; set; }
    }
}
