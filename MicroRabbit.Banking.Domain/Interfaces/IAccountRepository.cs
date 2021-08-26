using System.Collections.Generic;
using System.Threading.Tasks;
using MicroRabbit.Banking.Domain.Models;

namespace MicroRabbit.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        Task<IReadOnlyList<Account>> GetAccounts();
    }
}