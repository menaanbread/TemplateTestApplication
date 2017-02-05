using TemplateTestApplication.Domain;
using TemplateTestApplication.Domain.Interfaces;

namespace TemplateTestApplication.Services
{
    public class TransactionMethodFactory : ITransactionMethodFactory
    {
        public ITransactionMethod GetTransactionMethod(TransactionMethodType transactionMethodType)
        {
            ITransactionMethod transactionMethod;

            switch (transactionMethodType)
            {
                case TransactionMethodType.DebitCard:
                    transactionMethod = new DebitCardTransactionMethod();
                    break;
                case TransactionMethodType.Paypal:
                    transactionMethod = new PaypalTransactionMethod();
                    break;
                default:
                    throw new UnsupportedTransactionMethodException(string.Format("Attempted to retrieve an invalid Transaction Method: {0}", transactionMethodType.ToString()));
            }

            return transactionMethod;
        }
    }
}
