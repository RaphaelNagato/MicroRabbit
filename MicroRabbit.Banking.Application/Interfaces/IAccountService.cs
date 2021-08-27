using System.Collections.Generic;
using System.Threading.Tasks;
using MicroRabbit.Banking.Application.Dtos;
using MicroRabbit.Banking.Domain.Models;

namespace MicroRabbit.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        Task<IReadOnlyList<Account>> GetAccounts();
        void Transfer(AccountTransferDto accountTransfer);
    }
}