using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MuenYang.SMZG.Roles.Dto;
using MuenYang.SMZG.Users.Dto;

namespace MuenYang.SMZG.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}