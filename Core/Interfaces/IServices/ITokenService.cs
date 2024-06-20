using Core.Entities.AuthEntities;

namespace Core.Interfaces.IServices
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}
