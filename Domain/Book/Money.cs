﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Book
{
    public sealed class Money 
    {
        public decimal Amount { get; private set; }
        public string Currency { get; private set; }
        
        public Money (decimal amount , string currency)
        {
            if (amount < 0 ) throw new ArgumentException("Amount cannot be negative.");
            Amount = amount;
            Currency = currency;
        }
    }
}
