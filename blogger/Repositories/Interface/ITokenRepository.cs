using Microsoft.AspNetCore.Identity;

namespace blogger.Repositories.Interface
{
    public interface ITokenRepository
    {
        string CreateJwtToken(IdentityUser user, List<string> roles);
    }
}