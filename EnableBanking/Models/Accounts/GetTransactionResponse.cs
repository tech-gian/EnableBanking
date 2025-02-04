using Newtonsoft.Json;

namespace EnableBanking.Models.Accounts
{
    public class GetTransactionResponse : Transaction
    {
    }

    public class Transaction
    {
        [JsonProperty("transaction_amount")]
        public AmountDetails? TransactionAmount { get; set; }

        [JsonProperty("credit_debit_indicator")]
        public string? CreditDebitIndicator { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("entry_reference")]
        public string? EntryReference { get; set; }

        [JsonProperty("merchant_category_code")]
        public string? MerchantCategoryCode { get; set; }

        [JsonProperty("creditor")]
        public PartyDetails? Creditor { get; set; }

        [JsonProperty("creditor_account")]
        public AccountDetails? CreditorAccount { get; set; }

        [JsonProperty("creditor_agent")]
        public AgentDetails? CreditorAgent { get; set; }

        [JsonProperty("debtor")]
        public PartyDetails? Debtor { get; set; }

        [JsonProperty("debtor_account")]
        public AccountDetails? DebtorAccount { get; set; }

        [JsonProperty("debtor_agent")]
        public AgentDetails? DebtorAgent { get; set; }

        [JsonProperty("bank_transaction_code")]
        public BankTransactionCode? BankTransactionCode { get; set; }

        [JsonProperty("proprietaryBankTransactionCode")]
        public string? ProprietaryBankTransactionCode { get; set; }

        [JsonProperty("booking_date")]
        public string? BookingDate { get; set; }

        [JsonProperty("value_date")]
        public string? ValueDate { get; set; }

        [JsonProperty("transactionInformation")]
        public string? TransactionInformation { get; set; }

        [JsonProperty("transaction_date")]
        public string? TransactionDate { get; set; }

        [JsonProperty("balance_after_transaction")]
        public AmountDetails? BalanceAfterTransaction { get; set; }

        [JsonProperty("balance")]
        public TransactionBalance? Balance { get; set; }

        [JsonProperty("reference_number")]
        public string? ReferenceNumber { get; set; }

        [JsonProperty("remittance_information")]
        public string[]? RemittanceInformation { get; set; }

        [JsonProperty("debtor_account_additional_identification")]
        public IdentificationDetails[]? DebtorAccountAdditionalIdentification { get; set; }

        [JsonProperty("creditor_account_additional_identification")]
        public IdentificationDetails[]? CreditorAccountAdditionalIdentification { get; set; }

        [JsonProperty("exchange_rate")]
        public ExchangeRateDetails? ExchangeRate { get; set; }

        [JsonProperty("note")]
        public string? Note { get; set; }

        [JsonProperty("transaction_id")]
        public string? TransactionId { get; set; }
    }

    public class AmountDetails
    {
        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("amount")]
        public string? Amount { get; set; }
    }

    public class PartyDetails
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("postal_address")]
        public PostalAddress? PostalAddress { get; set; }

        [JsonProperty("organisation_id")]
        public IdentificationDetails? OrganisationId { get; set; }

        [JsonProperty("private_id")]
        public IdentificationDetails? PrivateId { get; set; }

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

    public class IdentificationDetails
    {
        [JsonProperty("identification")]
        public string? Identification { get; set; }

        [JsonProperty("scheme_name")]
        public string? SchemeName { get; set; }

        [JsonProperty("issuer")]
        public string? Issuer { get; set; }
    }

    public class ContactDetails
    {
        [JsonProperty("email_address")]
        public string? EmailAddress { get; set; }

        [JsonProperty("phone_number")]
        public string? PhoneNumber { get; set; }
    }

    public class AccountDetails
    {
        [JsonProperty("iban")]
        public string? Iban { get; set; }

        [JsonProperty("other")]
        public IdentificationDetails? Other { get; set; }
    }

    public class AgentDetails
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

    public class BankTransactionCode
    {
        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("code")]
        public string? Code { get; set; }

        [JsonProperty("sub_code")]
        public string? SubCode { get; set; }
    }

    public class ExchangeRateDetails
    {
        [JsonProperty("unit_currency")]
        public string? UnitCurrency { get; set; }

        [JsonProperty("exchange_rate")]
        public string? ExchangeRate { get; set; }

        [JsonProperty("rate_type")]
        public string? RateType { get; set; }

        [JsonProperty("contract_identification")]
        public string? ContractIdentification { get; set; }

        [JsonProperty("instructed_amount")]
        public AmountDetails? InstructedAmount { get; set; }
    }
}
