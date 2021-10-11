using MtDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MtDemo.Permissions
{
    public class MtDemoPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(MtDemoPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(MtDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MtDemoResource>(name);
        }
    }
}
