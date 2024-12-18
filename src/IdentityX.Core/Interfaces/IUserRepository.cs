using IdentityX.Core.Entities;

namespace IdentityX.Core.Interfaces;

public interface IUserRepository
{
    Task<User?> GetUserByUsernameAsync(string username);
    Task<User?> GetUserByUsernameOrEmailAsync(string username, string email);
    Task RegisterUserAsync(User? user);
    Task<List<User?>> GetAllUsersAsync();
}