using TemplateTestApplication.Domain;
using TemplateTestApplication.Domain.Interfaces;

namespace TemplateTestApplication.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionMethodFactory _transactionMethodFactory;
        private readonly IBalanceService _balanceService;

        public TransactionService(ITransactionMethodFactory transactionMethodFactory, IBalanceService balanceService)
        {
            _transactionMethodFactory = transactionMethodFactory;
            _balanceService = balanceService;
        }

        public DepositResponse Deposit(DepositRequest depositRequest)
        {
            var transactionMethod = _transactionMethodFactory.GetTransactionMethod(depositRequest.TransactionMethod);
            var response = new DepositResponse { Success = false };
            
            if (transactionMethod.Deposit(depositRequest.Amount))
            {
                response.NewBalance = _balanceService.UpdateBalance(depositRequest.Amount);
            }

            return response;
        }

        public WithdrawalResponse Withdraw(WithdrawalRequest withdrawalRequest)
        {
            var response = new WithdrawalResponse { Success = false };

            if (_balanceService.GetBalance() > withdrawalRequest.Amount)
            {
                var transactionMethod = _transactionMethodFactory.GetTransactionMethod(withdrawalRequest.TransactionMethod);

                if (transactionMethod.Withdraw(withdrawalRequest.Amount))
                {
                    response.NewBalance = _balanceService.UpdateBalance(withdrawalRequest.Amount);
                }
            }
            
            return response;
        }
    }
}
