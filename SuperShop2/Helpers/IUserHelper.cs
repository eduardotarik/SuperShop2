using Microsoft.AspNetCore.Identity;
using SuperShop2.Data.Entities;
using System.Threading.Tasks;

namespace SuperShop2.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);
    }
}
