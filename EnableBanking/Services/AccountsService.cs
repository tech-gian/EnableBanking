using EnableBanking.Interfaces;
using EnableBanking.Models;
using EnableBanking.Models.Accounts;

namespace EnableBanking.Services
{
    public class AccountsService : HttpClientService, IAccountsService
    {
        public AccountsService(HttpClient httpClient)
            : base(httpClient) { }

        public async Task<ApiResponse<GetTransactionsResponse>> GetTransactionsAsync(GetTransactionsRequest request, CancellationToken cancellationToken)
        {
            var requestUri = $"{request.AccountId}/transactions?";
            if (request.DateFrom != null)
            {
                requestUri += $"date_from={request.DateFrom}&";
            }
            if (request.DateTo != null)
            {
                requestUri += $"date_to={request.DateTo}&";
            }
            if (!string.IsNullOrEmpty(request.ContinuationKey))
            {
                requestUri += $"continuation_key={request.ContinuationKey}&";
            }
            if (!string.IsNullOrEmpty(request.TransactionStatus))
            {
                requestUri += $"transaction_status={request.TransactionStatus}&";
            }
            if (request.Strategy != null)
            {
                requestUri += $"strategy={request.Strategy}&";
            }

            return await GetAsync<GetTransactionsResponse>(requestUri, cancellationToken);
        }

        public async Task<ApiResponse<GetTransactionResponse>> GetTransactionAsync(GetTransactionRequest request, CancellationToken cancellationToken)
        {
            var requestUri = $"{request.AccountId}/transactions/{request.TransactionId}";
            return await GetAsync<GetTransactionResponse>(requestUri, cancellationToken);
        }

        public async Task<ApiResponse<GetDetailsResponse>> GetDetailsAsync(GetDetailsRequest request, CancellationToken cancellationToken)
        {
            var requestUri = $"{request.AccountId}/details";
            return await GetAsync<GetDetailsResponse>(requestUri, cancellationToken);
        }

        public async Task<ApiResponse<GetBalancesResponse>> GetBalancesAsync(GetBalancesRequest request, CancellationToken cancellationToken)
        {
            var requestUri = $"{request.AccountId}/balances";
            return await GetAsync<GetBalancesResponse>(requestUri, cancellationToken);
        }
    }
}
