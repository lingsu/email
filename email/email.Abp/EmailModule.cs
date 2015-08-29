using System.Reflection;
using Abp.Modules;
using email.Configuration;
using email.Delivery;
using email.Providers;
using email.Templates;

namespace email.Abp
{
    public class EmailModule: AbpModule
    {
        public const string CurrentVersion = "0.6.7.0";
        public override void PreInitialize()
        {
            IocManager.Register<ISmtpConfig, SmtpConfig>();
            IocManager.Register<IEmailProvider,SmtpEmailProvider>();
            IocManager.Register<IEmailTemplateEngine, DotLiquidEmailTemplateEngine>();
            IocManager.Register<IDeliveryConfiguration, DeliveryConfiguration>();
            IocManager.Register<IDeliveryService, DeliveryService>();
        }
        public override void Initialize()
        {
            //IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
           IocManager.Resolve<IDeliveryService>().Start();
        }

        public override void Shutdown()
        {
            IocManager.Resolve<IDeliveryService>().Stop();
        }
    }
}