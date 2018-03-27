using Abp.Authorization;
using MuenYang.SMZG.Authorization.Roles;
using MuenYang.SMZG.Authorization.Users;

namespace MuenYang.SMZG.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
