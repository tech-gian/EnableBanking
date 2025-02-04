using EnableBanking.Interfaces;
using EnableBanking.Models;
using EnableBanking.Models.General;

namespace EnableBanking.Services
{
    public class GeneralService : HttpClientService, IGeneralService
    {
        public GeneralService(HttpClient httpClient)
            : base(httpClient) { }

        public async Task<ApiResponse<StartAuthorizationResponse>> StartAuthorizationAsync(StartAuthorizationRequest request, CancellationToken cancellationToken)
        {
            var requestUri = "auth";
            return await PostAsync<StartAuthorizationResponse>(requestUri, request, cancellationToken);
        }

        public async Task<ApiResponse<GetASPSPsResponse>> GetASPSPsAsync(GetASPSPsRequest request, CancellationToken cancellationToken)
        {
            var requestUri = "aspsps?";
            if (!string.IsNullOrEmpty(request.Country))
            {
                requestUri += $"country={request.Country}&";
            }
            if (!string.IsNullOrEmpty(request.PsuType))
            {
                requestUri += $"psu_type={request.PsuType}&";
            }
            if (!string.IsNullOrEmpty(request.Service))
            {
                requestUri += $"service={request.Service}&";
            }
            if (!string.IsNullOrEmpty(request.PaymentType))
            {
                requestUri += $"payment_type={request.PaymentType}&";
            }

            return await GetAsync<GetASPSPsResponse>(requestUri, cancellationToken);
        }

        public async Task<ApiResponse<GetApplicationResponse>> GetApplicationAsync(GetApplicationRequest request, CancellationToken cancellationToken)
        {
            var requestUri = "application";
            return await GetAsync<GetApplicationResponse>(requestUri, cancellationToken);
        }
    }
}
