namespace TemplateTestApplication.Domain.Interfaces
{
    public interface ITransactionMethod
    {
        bool Deposit(decimal amount);
        bool Withdraw(decimal amount);
    }
}
