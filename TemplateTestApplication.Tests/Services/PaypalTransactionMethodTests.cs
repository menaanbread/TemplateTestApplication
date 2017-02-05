using FluentAssertions;
using NUnit.Framework;
using TemplateTestApplication.Domain.Interfaces;
using TemplateTestApplication.Services;

namespace TemplateTestApplication.Tests.Services
{
    [TestFixture]
    public class PaypalTransactionMethodTests
    {
        private ITransactionMethod _transactionMethod;

        [SetUp]
        public void Setup()
        {
            _transactionMethod = new PaypalTransactionMethod();
        }

        [TestCase(249)]
        [Category("Paypal")]
        public void When_Withdraw_Expect_Success_When_Amount_Below_250(decimal amount)
        {
            var actual = _transactionMethod.Withdraw(amount);

            actual.ShouldBeEquivalentTo(true);
        }
    }
}
