namespace TemplateTestApplication.Domain
{
    public class DepositRequest
    {
        public decimal Amount { get; set; }
        public TransactionMethodType TransactionMethod { get; set; }
    }
}