using LoginApiN.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace LoginApiN.Data
{
    public class LoginAPINContext: IdentityDbContext<ApplicationUser>
    {
        public LoginAPINContext(DbContextOptions<LoginAPINContext> options) :base(options)
        {
                
        }
        public DbSet<Books> Books { get; set; }
    }
    
}
