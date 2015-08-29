using Abp.Configuration.Startup;
using email.Configuration;

namespace email.Abp.Configuration
{
    public static class ModuleSmtpConfigurationExtensions
    {
       
        public static ISmtpConfig Email(this IModuleConfigurations moduleConfigurations)
        {
            return moduleConfigurations.AbpConfiguration
                .GetOrCreate("SmtpConfig",
                    () => moduleConfigurations.AbpConfiguration.IocManager.Resolve<ISmtpConfig>()
                );
        }
    }
}