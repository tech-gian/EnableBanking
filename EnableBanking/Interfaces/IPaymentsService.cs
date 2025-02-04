using EnableBanking.Models;
using EnableBanking.Models.Payments;

namespace EnableBanking.Interfaces
{
    public interface IPaymentsService
    {
        Task<ApiResponse<GetPaymentResponse>> GetPaymentAsync(GetPaymentRequest request, CancellationToken cancellationToken);

        Task<ApiResponse<GetPaymentTransactionResponse>> GetPaymentTransactionAsync(GetPaymentTransactionRequest request, CancellationToken cancellationToken);

        Task<ApiResponse<CreatePaymentResponse>> CreatePaymentAsync(CreatePaymentRequest request, CancellationToken cancellationToken);
    }
}
