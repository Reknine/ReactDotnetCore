using Domain;

namespace Application.User
{
    public interface IJwtGenerator
    {
         string CreateToken(AppUser user);
    }
}