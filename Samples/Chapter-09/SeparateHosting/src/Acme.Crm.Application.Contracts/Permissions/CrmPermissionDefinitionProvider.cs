using Acme.Crm.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.Crm.Permissions
{
    public class CrmPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(CrmPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(CrmPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<CrmResource>(name);
        }
    }
}
