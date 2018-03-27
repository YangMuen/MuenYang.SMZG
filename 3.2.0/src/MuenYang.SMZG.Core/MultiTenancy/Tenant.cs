using Abp.MultiTenancy;
using MuenYang.SMZG.Authorization.Users;

namespace MuenYang.SMZG.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}