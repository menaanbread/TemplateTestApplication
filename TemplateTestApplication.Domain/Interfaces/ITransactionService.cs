namespace TemplateTestApplication.Domain.Interfaces
{
    public interface ITransactionService
    {
        DepositResponse Deposit(DepositRequest depositRequest);
        WithdrawalResponse Withdraw(WithdrawalRequest withdrawalRequest);
    }
}
