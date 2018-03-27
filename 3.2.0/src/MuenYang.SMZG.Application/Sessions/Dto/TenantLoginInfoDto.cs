using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MuenYang.SMZG.MultiTenancy;

namespace MuenYang.SMZG.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}