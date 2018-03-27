using System.Threading.Tasks;
using Abp.Application.Services;
using MuenYang.SMZG.Configuration.Dto;

namespace MuenYang.SMZG.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}