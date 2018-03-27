using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using MuenYang.SMZG.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace MuenYang.SMZG.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<SMZG.EntityFramework.SMZGDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SMZG";
        }

        protected override void Seed(SMZG.EntityFramework.SMZGDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
