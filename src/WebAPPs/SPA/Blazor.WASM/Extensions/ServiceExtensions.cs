using Blazor.Extensions.Storage;
using HomeAPP.WebAPPs.SPA.Blazor.WASM.Services.Repositories.Abstractions;
using HomeAPP.WebAPPs.SPA.Blazor.WASM.Services.Repositories.Implementations;
using HomeAPP.WebAPPs.SPA.Blazor.WASM.Services.Services.Abstractions;
using HomeAPP.WebAPPs.SPA.Blazor.WASM.Services.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;

namespace HomeAPP.WebAPPs.SPA.Blazor.WASM.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services) =>
            services.AddScoped<IStorageRepository, StorageRepository>()
                    .AddSingleton<IRefresherService, RefresherService>();

        public static IServiceCollection AddExternalServices(this IServiceCollection services) => 
            services.AddStorage()
                    .AddLocalization(opts => { opts.ResourcesPath = "Resources"; });

        public static IServiceCollection AddHttpClient(this IServiceCollection services, string baseURI) =>
            services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(baseURI) });
    }
}
