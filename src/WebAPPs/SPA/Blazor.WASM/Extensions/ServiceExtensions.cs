using AKSoftware.Localization.MultiLanguages;
using Blazor.Extensions.Storage;
using HomeAPP.WebAPPs.SPA.Blazor.WASM.Services.Repositories.Abstractions;
using HomeAPP.WebAPPs.SPA.Blazor.WASM.Services.Repositories.Implementations;
using Microsoft.Extensions.DependencyInjection;
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
            services.AddScoped<IStorageRepository, StorageRepository>();

        public static IServiceCollection AddExternalServices(this IServiceCollection services) => 
            services.AddLanguageContainer(Assembly.GetExecutingAssembly()).AddStorage();

        public static IServiceCollection AddHttpClient(this IServiceCollection services, string baseURI) =>
            services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(baseURI) });
    }
}
