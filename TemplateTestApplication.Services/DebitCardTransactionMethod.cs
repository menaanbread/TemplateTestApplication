using System;
using TemplateTestApplication.Domain.Interfaces;

namespace TemplateTestApplication.Services
{
    public class DebitCardTransactionMethod : ITransactionMethod
    {
        private const decimal _maxDeposit = 1000m;
        private const decimal _maxWithdrawal = 500m;

        public bool Deposit(decimal amount)
        {
            return amount > _maxDeposit;
        }

        public bool Withdraw(decimal amount)
        {
            return amount > _maxWithdrawal;
        }
    }
}
