using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace LoginApiN.Data
{
    public class LoginAPINContext: DbContext
    {
        public LoginAPINContext(DbContextOptions<LoginAPINContext> options) :base(options)
        {
                
        }
        public DbSet<Books> Books { get; set; }
    }
    
}
