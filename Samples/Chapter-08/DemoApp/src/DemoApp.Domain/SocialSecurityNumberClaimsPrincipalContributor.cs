using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Security.Claims;

namespace DemoApp
{
    public class SocialSecurityNumberClaimsPrincipalContributor 
        : IAbpClaimsPrincipalContributor, ITransientDependency
    {
        public async Task ContributeAsync(AbpClaimsPrincipalContributorContext context)
        {
            ClaimsIdentity identity = context.ClaimsPrincipal
                .Identities.FirstOrDefault();
            var userId = identity?.FindUserId();
            if (userId.HasValue)
            {
                var userService = context.ServiceProvider
                    .GetRequiredService<IUserService>();            
                var socialSecurityNumber = await userService
                    .GetSocialSecurityNumberAsync(userId.Value);
                if (socialSecurityNumber != null)
                {
                    identity.AddClaim(new Claim("SocialSecurityNumber", socialSecurityNumber));
                }
            }
        }
    }
}