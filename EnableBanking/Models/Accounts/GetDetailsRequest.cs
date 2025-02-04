using Newtonsoft.Json;

namespace EnableBanking.Models.Accounts
{
    public class GetDetailsRequest
    {
        [JsonProperty("account_id")]
        public Guid? AccountId { get; set; }
    }
}
