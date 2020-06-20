using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Model.Models 
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base (options) { 

            
        }
        public DbSet<Student> BaseEntities{ get; set; }
        public DbSet<Evaluator> Evaluators{ get; set; }
        public DbSet<EconomicStudy> EconomicStudies{ get; set; }
    }
}