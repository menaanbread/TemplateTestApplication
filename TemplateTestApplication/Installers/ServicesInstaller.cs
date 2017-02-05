using System;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using TemplateTestApplication.Domain.Interfaces;
using TemplateTestApplication.Services;

namespace TemplateTestApplication.Installers
{
    public class ServicesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IBalanceService>().ImplementedBy<BalanceService>().LifestyleSingleton());
            container.Register(Component.For<ITransactionMethodFactory>().ImplementedBy<TransactionMethodFactory>().LifestyleSingleton());
            container.Register(Component.For<ITransactionService>().ImplementedBy<TransactionService>().LifestyleSingleton());
        }
    }
}