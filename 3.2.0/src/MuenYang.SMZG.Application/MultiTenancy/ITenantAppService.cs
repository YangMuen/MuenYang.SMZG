using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MuenYang.SMZG.MultiTenancy.Dto;

namespace MuenYang.SMZG.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
