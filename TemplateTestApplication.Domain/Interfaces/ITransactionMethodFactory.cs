namespace TemplateTestApplication.Domain.Interfaces
{
    public interface ITransactionMethodFactory
    {
        ITransactionMethod GetTransactionMethod(TransactionMethodType transactionMethodType);
    }
}
