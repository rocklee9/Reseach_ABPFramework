using Tcx.xdcb.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Tcx.xdcb.Permissions
{
    public class xdcbPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(xdcbPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(xdcbPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<xdcbResource>(name);
        }
    }
}
