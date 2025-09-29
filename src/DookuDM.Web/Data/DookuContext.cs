using Microsoft.EntityFrameworkCore;
using DookuDM.Web.Models;

namespace DookuDM.Web.Data
{
    public class DookuContext : DbContext
    {
        public DookuContext(DbContextOptions<DookuContext> options) : base(options) { }
        
        public DbSet<User> Users { get; set; }
    }
}