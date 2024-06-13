using Core.Entities.AuthEntities;

namespace Core.Interfaces.IServices
{
    public interface ITokenService
    {
        string CreateToken(AppUser appUser);
    }
}
