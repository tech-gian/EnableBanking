using EnableBanking.Models;
using EnableBanking.Models.Accounts;

namespace EnableBanking.Interfaces
{
    public interface IAccountsService
    {
        Task<ApiResponse<GetTransactionsResponse>> GetTransactionsAsync(GetTransactionsRequest request, CancellationToken cancellationToken);

        Task<ApiResponse<GetTransactionResponse>> GetTransactionAsync(GetTransactionRequest request, CancellationToken cancellationToken);

        Task<ApiResponse<GetDetailsResponse>> GetDetailsAsync(GetDetailsRequest request, CancellationToken cancellationToken);

        Task<ApiResponse<GetBalancesResponse>> GetBalancesAsync(GetBalancesRequest request, CancellationToken cancellationToken);
    }
}
