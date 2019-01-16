using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Evol.Ant.Authorization;

namespace Evol.Ant
{
    [DependsOn(
        typeof(AntCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AntApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AntAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AntApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
