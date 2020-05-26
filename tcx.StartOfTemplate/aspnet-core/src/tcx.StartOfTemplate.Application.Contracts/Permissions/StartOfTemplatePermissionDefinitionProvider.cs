using tcx.StartOfTemplate.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace tcx.StartOfTemplate.Permissions
{
    public class StartOfTemplatePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(StartOfTemplatePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(StartOfTemplatePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<StartOfTemplateResource>(name);
        }
    }
}
