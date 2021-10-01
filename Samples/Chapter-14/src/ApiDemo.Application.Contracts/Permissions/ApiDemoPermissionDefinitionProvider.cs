using ApiDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ApiDemo.Permissions
{
    public class ApiDemoPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ApiDemoPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(ApiDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ApiDemoResource>(name);
        }
    }
}
