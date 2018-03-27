using System.Threading.Tasks;
using Abp.Application.Services;
using MuenYang.SMZG.Sessions.Dto;

namespace MuenYang.SMZG.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
