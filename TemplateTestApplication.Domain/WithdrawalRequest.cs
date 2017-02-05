namespace TemplateTestApplication.Domain
{
    public class WithdrawalRequest
    {
        public decimal Amount { get; set; }
        public TransactionMethodType TransactionMethod { get; set; }
    }
}