using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MicroRabbit.Banking.Data.Config
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.AccountType).IsRequired();
            builder.Property(a => a.AccountBalance).IsRequired().HasColumnType("decimal(18,2)");
        }
    }
}