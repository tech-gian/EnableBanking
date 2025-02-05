# .NET Client for the EnableBanking API

For full details of the EnableBanking API, see the [Docs](https://enablebanking.com/docs/).

[![NuGet](https://img.shields.io/nuget/v/EnableBanking.svg)](https://www.nuget.org/packages/EnableBanking/)
[![<EnableBanking>](https://github.com/tech-gian/EnableBanking/actions/workflows/publish.yml/badge.svg)](https://github.com/tech-gian/EnableBanking/actions)

- [Quick Start](https://enablebanking.com/docs/api/quick-start/)
- [API Reference](https://enablebanking.com/docs/api/reference/)
- [Sandbox Environment](https://enablebanking.com/docs/api/sandbox/)
- [NuGet Package](https://)

## Installation

To install `EnableBanking`, run the following command in the [Package Manager Console](https://docs.microsoft.com/en-us/nuget/tools/package-manager-console)

`Install-Package EnableBanking -Version 1.0.0`


## Usage

### Add a new Application

First of all, a new application needs to be registered to the [EnableBanking portal](https://enablebanking.com/cp/applications/) (follow the instructions there). The private RSA needs to be saved and be accessible from the main .NET project.

### Add Services using Dependency Injection

The services need to be registered in the `Program.cs` like this:

```cs
builder.Services.AddEnableBankingApi(options =>
{
    options.KeyPath = "your_path_to_key";
    options.AppKid = "your_app_kid";
});
```

After that you can inject any of the following `Interfaces` in to your constructors and use their methods.

```cs
private readonly IGeneralService _generalService;

public TestClass(IGeneralService generalService)
{
    _generalService = generalService;
}
```

#### Example of a Request

Below there is an example request. Every method has the same pattern regarding the request and response models. The only thing that varies from method to method is the actual properties.

```cs
var request = new GetApplicationRequest();
var response = await _generalService.GetApplicationAsync(request, cancellationToken);

// Successful Response
if (response.Data != null)
{
    var applicationName = response.Data.Name;
}
// Unsuccessful Response
else if (response.Error != null)
{
    var errorMessage = response.Error.Message;
}
```

### Interfaces

Below are mentioned all the methods of each Interface, that can be used like in the example above:

*IGeneralService*

```cs
public interface IGeneralService
{
    Task<ApiResponse<StartAuthorizationResponse>> StartAuthorizationAsync(StartAuthorizationRequest request, CancellationToken cancellationToken);

    Task<ApiResponse<GetASPSPsResponse>> GetASPSPsAsync(GetASPSPsRequest request, CancellationToken cancellationToken);

    Task<ApiResponse<GetApplicationResponse>> GetApplicationAsync(GetApplicationRequest request, CancellationToken cancellationToken);
}
```

*ISessionsService*

```cs
public interface ISessionsService
{
    Task<ApiResponse<GetSessionResponse>> GetSessionAsync(GetSessionRequest request, CancellationToken cancellationToken);

    Task<ApiResponse<DeleteSessionResponse>> DeleteSessionAsync(DeleteSessionRequest request, CancellationToken cancellationToken);

    Task<ApiResponse<AuthorizeSessionResponse>> AuthorizeSessionAsync(AuthorizeSessionRequest request, CancellationToken cancellationToken);
}
```

*IAccountsService*

```cs
public interface IAccountsService
{
    Task<ApiResponse<GetTransactionsResponse>> GetTransactionsAsync(GetTransactionsRequest request, CancellationToken cancellationToken);

    Task<ApiResponse<GetTransactionResponse>> GetTransactionAsync(GetTransactionRequest request, CancellationToken cancellationToken);

    Task<ApiResponse<GetDetailsResponse>> GetDetailsAsync(GetDetailsRequest request, CancellationToken cancellationToken);

    Task<ApiResponse<GetBalancesResponse>> GetBalancesAsync(GetBalancesRequest request, CancellationToken cancellationToken);
}
```

*IPaymentsService*

```cs
public interface IPaymentsService
{
    Task<ApiResponse<GetPaymentResponse>> GetPaymentAsync(GetPaymentRequest request, CancellationToken cancellationToken);

    Task<ApiResponse<GetPaymentTransactionResponse>> GetPaymentTransactionAsync(GetPaymentTransactionRequest request, CancellationToken cancellationToken);

    Task<ApiResponse<CreatePaymentResponse>> CreatePaymentAsync(CreatePaymentRequest request, CancellationToken cancellationToken);
}
```

### Unsuccessful Requests

The ApiResponse class contains only 3 properties:
- The actual `Data`, in case of a successful request
- The `Error`, in case of an unsuccessful request
- The `StatusCode`, in both cases

In the case of an unsuccessful request, the Error class has the following properties:

```cs
public class ApiError
{
    [JsonProperty("message")]
    public string? Message { get; set; }

    [JsonProperty("code")]
    public string? Code { get; set; }

    [JsonProperty("error")]
    public string? Error { get; set; }

    [JsonProperty("detail")]
    public object? Detail { get; set; }
}
```

### Errors

The possible errors, based on the API documentation are:

- `Bad Request`
- `Unauthorized`
- `Forbidden`
- `Not Found`
- `Request Timeout`
- `Unprocessable Entity`
- `Too Many Requests`
- `Internal Server Error`

These errors are fully documented in the [API Reference](https://enablebanking.com/docs/api/reference/).

### Support and feedback

If you find any problem or issue in the code, I'm more than happy to help you with that or fix any possible bug found.

You are more than welcome to raise any issue in the repository or contact me through my email: `zapantis2@gmail.com`
