using Microsoft.EntityFrameworkCore;

namespace DookuDM.Web.Data
{
    public class DookuContext : DbContext
    {
        public DookuContext(DbContextOptions<DookuContext> options) : base(options)
        {
        }
        
        public DbSet<User> Users { get; set; }
    }

    
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}