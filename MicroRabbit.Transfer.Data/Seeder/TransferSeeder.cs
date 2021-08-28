using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Transfer.Data.Seeder
{
    public class TransferSeeder
    {
        public static async Task SeedAsync(TransferDbContext context)
        {
            await context.Database.MigrateAsync();
            if (!context.TransferLogs.Any())
            {
                try
                {
                    var buildDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    var filePath = buildDir + @"/SeederData/TransferLogs.json";
                    var transfersData = await File.ReadAllTextAsync(filePath);
                    var transfers = JsonSerializer.Deserialize<IReadOnlyList<TransferLog>>(transfersData);

                    await context.TransferLogs.AddRangeAsync(transfers);
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