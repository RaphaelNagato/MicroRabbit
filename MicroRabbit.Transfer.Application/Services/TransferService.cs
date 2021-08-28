using System.Collections.Generic;
using System.Threading.Tasks;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;

        public TransferService(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }

        public async Task<IReadOnlyList<TransferLog>> GetTransferLogs()
        {
            return await _transferRepository.GetTransferLogs();
        }
    }
}