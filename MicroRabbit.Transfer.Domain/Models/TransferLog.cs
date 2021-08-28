namespace MicroRabbit.Transfer.Domain.Models
{
    public class TransferLog
    {
        public string Id { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal Amount { get; set; }
    }
}