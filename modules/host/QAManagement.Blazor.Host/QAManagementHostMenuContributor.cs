using System.Threading.Tasks;
using QAManagement.Localization;
using Volo.Abp.UI.Navigation;

namespace QAManagement.Blazor.Host
{
    public class QAManagementHostMenuContributor : IMenuContributor
    {
        public Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if(context.Menu.DisplayName != StandardMenus.Main)
            {
                return Task.CompletedTask;
            }

            var l = context.GetLocalizer<QAManagementResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    "QAManagement.Home",
                    l["Menu:Home"],
                    "/",
                    icon: "fas fa-home"
                )
            );

            return Task.CompletedTask;
        }
    }
}
