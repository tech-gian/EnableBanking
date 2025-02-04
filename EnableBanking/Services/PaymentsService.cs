using EnableBanking.Interfaces;
using EnableBanking.Models;
using EnableBanking.Models.Payments;

namespace EnableBanking.Services
{
    public class PaymentsService : HttpClientService, IPaymentsService
    {
        public PaymentsService(HttpClient httpClient)
            : base(httpClient) { }

        public async Task<ApiResponse<GetPaymentResponse>> GetPaymentAsync(GetPaymentRequest request, CancellationToken cancellationToken)
        {
            var requestUri = $"{request.PaymentId}";
            return await GetAsync<GetPaymentResponse>(requestUri, cancellationToken);
        }

        public async Task<ApiResponse<GetPaymentTransactionResponse>> GetPaymentTransactionAsync(GetPaymentTransactionRequest request, CancellationToken cancellationToken)
        {
            var requestUri = $"{request.PaymentId}/transactions/{request.TransactionId}";
            return await GetAsync<GetPaymentTransactionResponse>(requestUri, cancellationToken);
        }

        public async Task<ApiResponse<CreatePaymentResponse>> CreatePaymentAsync(CreatePaymentRequest request, CancellationToken cancellationToken)
        {
            var requestUri = "";
            return await PostAsync<CreatePaymentResponse>(requestUri, request, cancellationToken);
        }
    }
}
