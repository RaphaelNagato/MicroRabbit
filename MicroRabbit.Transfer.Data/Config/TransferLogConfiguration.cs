using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MicroRabbit.Transfer.Data.Config
{
    public class TransferLogConfiguration : IEntityTypeConfiguration<TransferLog>
    {
        public void Configure(EntityTypeBuilder<TransferLog> builder)
        {
            builder.Property(t => t.Id).ValueGeneratedOnAdd();
            builder.Property(t => t.FromAccount).IsRequired();
            builder.Property(t => t.ToAccount).IsRequired();
            builder.Property(t => t.Amount).IsRequired().HasColumnType("decimal(18,2)");
        }
    }
}