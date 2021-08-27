namespace MicroRabbit.Banking.Application.Dtos
{
    public class AccountTransferDto
    {
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal TransferAmount { get; set; }
    }
}