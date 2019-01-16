using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Evol.Ant.Configuration.Dto;

namespace Evol.Ant.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AntAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
