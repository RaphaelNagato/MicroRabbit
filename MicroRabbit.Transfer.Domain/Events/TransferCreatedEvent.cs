﻿using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public TransferCreatedEvent(int @from, int to, decimal amount)
        {
            From = @from;
            To = to;
            Amount = amount;
        }

        public int From { get; }
        public int To { get; }
        public decimal Amount { get; }
    }
}
