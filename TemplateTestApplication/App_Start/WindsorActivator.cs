using System;
using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(TemplateTestApplication.App_Start.WindsorActivator), "PreStart")]
[assembly: ApplicationShutdownMethodAttribute(typeof(TemplateTestApplication.App_Start.WindsorActivator), "Shutdown")]

namespace TemplateTestApplication.App_Start
{
    public static class WindsorActivator
    {
        static ContainerBootstrapper bootstrapper;

        public static void PreStart()
        {
            bootstrapper = ContainerBootstrapper.Bootstrap();
        }
        
        public static void Shutdown()
        {
            if (bootstrapper != null)
                bootstrapper.Dispose();
        }
    }
}