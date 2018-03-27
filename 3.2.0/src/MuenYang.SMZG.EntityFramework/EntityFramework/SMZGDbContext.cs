using System.Data.Common;
using Abp.Zero.EntityFramework;
using MuenYang.SMZG.Authorization.Roles;
using MuenYang.SMZG.Authorization.Users;
using MuenYang.SMZG.MultiTenancy;

namespace MuenYang.SMZG.EntityFramework
{
    public class SMZGDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public SMZGDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in SMZGDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of SMZGDbContext since ABP automatically handles it.
         */
        public SMZGDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public SMZGDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public SMZGDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
