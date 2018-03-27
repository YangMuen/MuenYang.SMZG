using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using MuenYang.SMZG.EntityFramework;

namespace MuenYang.SMZG
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(SMZGCoreModule))]
    public class SMZGDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<SMZGDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
