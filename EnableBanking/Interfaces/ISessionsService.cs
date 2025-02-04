using EnableBanking.Models;
using EnableBanking.Models.Sessions;

namespace EnableBanking.Interfaces
{
    public interface ISessionsService
    {
        Task<ApiResponse<GetSessionResponse>> GetSessionAsync(GetSessionRequest request, CancellationToken cancellationToken);

        Task<ApiResponse<DeleteSessionResponse>> DeleteSessionAsync(DeleteSessionRequest request, CancellationToken cancellationToken);

        Task<ApiResponse<AuthorizeSessionResponse>> AuthorizeSessionAsync(AuthorizeSessionRequest request, CancellationToken cancellationToken);
    }
}
