using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserLogin.Server.Models;

namespace UserLogin.Server.Data
{
    public class UserDBContext : IdentityDbContext<User> 
    {
        public UserDBContext(DbContextOptions<UserDBContext> options) :base(options)
        {
        }
    }
}
