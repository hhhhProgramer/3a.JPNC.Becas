using Microsoft.EntityFrameworkCore;

namespace Model.Models 
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base (options) { 

            
        }
        public DbSet<BaseEntity> BaseEntities{ get; set; }
    }
}