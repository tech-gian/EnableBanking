using EnableBanking.Handlers;
using EnableBanking.Interfaces;
using EnableBanking.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EnableBanking
{
    public static class ConfigureServices
    {
        private const string _baseAddress = "https://api.enablebanking.com/";

        public static IServiceCollection AddEnableBankingApi(
            this IServiceCollection services,
            Action<TokenHandlerOptions> configureOptions)
        {
            services.AddTransient<IGeneralService, GeneralService>();
            services.AddTransient<ISessionsService, SessionsService>();
            services.AddTransient<IAccountsService, AccountsService>();
            services.AddTransient<IPaymentsService, PaymentsService>();

            services.Configure(configureOptions);
            services.AddTransient<TokenHandler>();

            services.AddHttpClient<IGeneralService, GeneralService>(httpClient =>
            {
                httpClient.BaseAddress = new Uri($"{_baseAddress}");
            })
                .AddHttpMessageHandler<TokenHandler>();

            services.AddHttpClient<ISessionsService, SessionsService>(httpClient =>
            {
                httpClient.BaseAddress = new Uri($"{_baseAddress}sessions/");
            })
                .AddHttpMessageHandler<TokenHandler>();

            services.AddHttpClient<IAccountsService, AccountsService>(httpClient =>
            {
                httpClient.BaseAddress = new Uri($"{_baseAddress}accounts/");
            })
                .AddHttpMessageHandler<TokenHandler>();

            services.AddHttpClient<IPaymentsService, PaymentsService>(httpClient =>
            {
                httpClient.BaseAddress = new Uri($"{_baseAddress}payments/");
            })
                .AddHttpMessageHandler<TokenHandler>();

            return services;
        }
    }
}
