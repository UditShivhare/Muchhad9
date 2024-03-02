using Microsoft.EntityFrameworkCore;

namespace LoginAPI.Data
{
    public class LoginAPIContext :DbContext
    {
        public LoginAPIContext(DbContextOptions<LoginAPIContext> options) : base(options)
        {
                
        }
        public DbSet<Books> Books { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;Database=LoginAPI;Integrated Security=true");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
