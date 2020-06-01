using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using TCX.Student.Localization;
using TCX.Student.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace TCX.Student.Web.Menus
{
    public class StudentMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.ServiceProvider.GetRequiredService<IStringLocalizer<StudentResource>>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem("Student.Home", l["Menu:Home"], "/"));
            context.Menu.AddItem(
                new ApplicationMenuItem("Student.Class", l["Class"])
                    .AddItem(new ApplicationMenuItem("Student.Class", l["Class"], url: "/class"))
            );
        }
    }
}
