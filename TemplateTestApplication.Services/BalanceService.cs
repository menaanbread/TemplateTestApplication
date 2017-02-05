using System;
using TemplateTestApplication.Domain;
using TemplateTestApplication.Domain.Interfaces;

namespace TemplateTestApplication.Services
{
    public class BalanceService : IBalanceService
    {
        private static decimal _balance = 0m;

        public decimal GetBalance()
        {
            return _balance;
        }

        public decimal UpdateBalance(decimal byAmount)
        {
            var newBalance = _balance + byAmount;

            if (newBalance < 0)
            {
                throw new BalanceDroppedBelowZeroException(string.Format("Inavlid attempt to update balance of {0} by {1}", _balance, byAmount));
            }
            else
            {
                _balance = newBalance;
            }

            return newBalance;
        }
    }
}
