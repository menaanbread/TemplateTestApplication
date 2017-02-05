using TemplateTestApplication.Domain.Interfaces;

namespace TemplateTestApplication.Services
{
    public class PaypalTransactionMethod : ITransactionMethod
    {
        private const decimal _fixedDepositFee = 5m;
        private const decimal _maxDeposit = 500m;
        private const decimal _maxWithdrawal = 250m;


        public bool Deposit(decimal amount)
        {
            return amount < (_maxDeposit + _fixedDepositFee);
        }

        public bool Withdraw(decimal amount)
        {
            return amount < _maxWithdrawal;
        }
    }
}
