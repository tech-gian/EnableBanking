using System.Net;

namespace EnableBanking.Models
{
    public class ApiResponse<T>
    {
        public T? Data { get; set; }
        public ApiError? Error { get; set; }
        public HttpStatusCode? StatusCode { get; set; }
    }
}
