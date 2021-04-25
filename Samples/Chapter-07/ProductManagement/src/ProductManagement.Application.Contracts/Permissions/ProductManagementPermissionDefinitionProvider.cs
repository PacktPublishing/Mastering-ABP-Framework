using ProductManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ProductManagement.Permissions
{
    public class ProductManagementPermissionDefinitionProvider
        : PermissionDefinitionProvider
    {
        public override void Define(
            IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(
                "ProductManagement",
                L("ProductManagement"));
            myGroup.AddPermission(
                "ProductManagement.ProductCreation",
                L("ProductCreation"));
            myGroup.AddPermission(
                "ProductManagement.ProductDeletion",
                L("ProductDeletion"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString
                .Create<ProductManagementResource>(name);
        }
    }
}