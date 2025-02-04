using EnableBanking.Models;
using EnableBanking.Models.General;

namespace EnableBanking.Interfaces
{
    public interface IGeneralService
    {
        Task<ApiResponse<StartAuthorizationResponse>> StartAuthorizationAsync(StartAuthorizationRequest request, CancellationToken cancellationToken);

        Task<ApiResponse<GetASPSPsResponse>> GetASPSPsAsync(GetASPSPsRequest request, CancellationToken cancellationToken);

        Task<ApiResponse<GetApplicationResponse>> GetApplicationAsync(GetApplicationRequest request, CancellationToken cancellationToken);
    }
}
