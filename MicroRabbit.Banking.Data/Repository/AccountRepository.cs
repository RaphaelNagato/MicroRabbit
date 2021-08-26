using System.Collections.Generic;
using System.Threading.Tasks;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDbContext _ctx;
        
        public AccountRepository(BankingDbContext ctx)
        {
            _ctx = ctx;
        }
        
        public async Task<IReadOnlyList<Account>> GetAccounts()
        {
            return await _ctx.Accounts.ToListAsync();
        }
    }
}