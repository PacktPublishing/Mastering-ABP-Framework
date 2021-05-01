using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace ProductManagement
{
    public class ProductCreationRequirementHandler
        : AuthorizationHandler<ProductCreationRequirement>
    {
        protected override Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            ProductCreationRequirement requirement)
        {
            if (context.User.HasClaim(c => c.Type == "productManager"))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}