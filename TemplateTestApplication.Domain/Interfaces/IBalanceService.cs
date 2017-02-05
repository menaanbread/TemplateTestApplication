namespace TemplateTestApplication.Domain.Interfaces
{
    public interface IBalanceService
    {
        decimal GetBalance();
        decimal UpdateBalance(decimal byAmount);
    }
}
