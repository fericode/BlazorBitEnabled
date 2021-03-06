using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ATA.Check.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await CreateHostBuilder(args)
                .Build()
                .RunAsync();
        }

        public static WebAssemblyHostBuilder CreateHostBuilder(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault();

            builder.RootComponents.Add<App>("app");

            builder.Services.AddSingleton(new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            new Startup().ConfigureServices(builder.Services);

            return builder;
        }
    }
}
