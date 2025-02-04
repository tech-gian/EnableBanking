using Newtonsoft.Json;

namespace EnableBanking.Models.Accounts
{
    public class GetBalancesRequest
    {
        [JsonProperty("account_id")]
        public Guid? AccountId { get; set; }
    }
}
