using EnableBanking.Interfaces;
using EnableBanking.Models;
using EnableBanking.Models.Sessions;

namespace EnableBanking.Services
{
    public class SessionsService : HttpClientService, ISessionsService
    {
        public SessionsService(HttpClient httpClient)
            : base(httpClient) { }

        public async Task<ApiResponse<GetSessionResponse>> GetSessionAsync(GetSessionRequest request, CancellationToken cancellationToken)
        {
            var requestUri = $"{request.SessionId}";
            return await GetAsync<GetSessionResponse>(requestUri, cancellationToken);
        }

        public async Task<ApiResponse<DeleteSessionResponse>> DeleteSessionAsync(DeleteSessionRequest request, CancellationToken cancellationToken)
        {
            var requestUri = $"{request.SessionId}";
            return await DeleteAsync<DeleteSessionResponse>(requestUri, cancellationToken);
        }

        public async Task<ApiResponse<AuthorizeSessionResponse>> AuthorizeSessionAsync(AuthorizeSessionRequest request, CancellationToken cancellationToken)
        {
            var requestUri = $"";
            return await PostAsync<AuthorizeSessionResponse>(requestUri, request, cancellationToken);
        }
    }
}
