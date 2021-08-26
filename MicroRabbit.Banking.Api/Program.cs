using System;
using System.Threading.Tasks;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Seeder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MicroRabbit.Banking.Api
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using var serviceScope = host.Services.CreateScope();
            var services = serviceScope.ServiceProvider;

            try
            {
                var context = services.GetService<BankingDbContext>();
                await AccountSeeder.SeedAsync(context);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}