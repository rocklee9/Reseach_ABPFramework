using TCX.Student.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TCX.Student.Permissions
{
    public class StudentPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(StudentPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(StudentPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<StudentResource>(name);
        }
    }
}
