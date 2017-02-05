using System.Web.Mvc;
using TemplateTestApplication.Domain;
using TemplateTestApplication.Domain.Interfaces;

namespace TemplateTestApplication.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ITransactionService _transactionService;

        public DefaultController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Deposit(decimal amount, TransactionMethodType type)
        {
            return View(_transactionService.Deposit(new DepositRequest { Amount = amount, TransactionMethod = type }));
        }

        [HttpGet]
        public ActionResult Withdraw(decimal amount, TransactionMethodType type)
        {
            return View(_transactionService.Withdraw(new WithdrawalRequest { Amount = amount, TransactionMethod = type }));
        }
    }
}