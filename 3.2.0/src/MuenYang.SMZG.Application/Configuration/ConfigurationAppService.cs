using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MuenYang.SMZG.Configuration.Dto;

namespace MuenYang.SMZG.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SMZGAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
