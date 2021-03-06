using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using AKSoftware.Localization.MultiLanguages;
using System.Reflection;
using System.Globalization;
using Blazor.Extensions.Storage;
using HomeAPP.WebAPPs.SPA.Blazor.WASM.Extensions;

namespace HomeAPP.WebAPPs.SPA.Blazor.WASM
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddExternalServices()
                .AddServices()
                .AddHttpClient(builder.HostEnvironment.BaseAddress);

            builder.RootComponents.Add<App>("app");

            await builder.Build().RunAsync();
        }
    }
}
