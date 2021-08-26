using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Banking.Data.Seeder
{
    public class AccountSeeder
    {
        public static async Task SeedAsync(BankingDbContext context)
        {
            await context.Database.MigrateAsync();
            if (!context.Accounts.Any())
            {
                try
                {
                    var buildDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    var filePath = buildDir + @"/Data/Accounts.json";
                    var usersData = await File.ReadAllTextAsync(filePath);
                    var accounts = JsonSerializer.Deserialize<IReadOnlyList<Account>>(usersData);

                    await context.Accounts.AddRangeAsync(accounts);
                    await context.SaveChangesAsync();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}