using MvcDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MvcDemo.Permissions
{
    public class MvcDemoPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(MvcDemoPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(MvcDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MvcDemoResource>(name);
        }
    }
}
