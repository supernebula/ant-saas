using System.Threading.Tasks;
using Evol.Ant.Configuration.Dto;

namespace Evol.Ant.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
