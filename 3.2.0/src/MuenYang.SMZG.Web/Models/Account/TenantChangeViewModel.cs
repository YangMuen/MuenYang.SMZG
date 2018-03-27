using Abp.AutoMapper;
using MuenYang.SMZG.Sessions.Dto;

namespace MuenYang.SMZG.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}