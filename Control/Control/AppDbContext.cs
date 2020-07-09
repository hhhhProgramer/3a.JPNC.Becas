using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Model;

namespace Control
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base (options) { 

            
        }
        public DbSet<Evaluator> Evaluators{ get; set; }
        public DbSet<EconomicStudy> EconomicStudies{ get; set; }
        public DbSet<Student> Students{ get; set; }
        public DbSet<Visit> Visits{ get; set; }
        public DbSet<Tutor> Tutors{ get; set; }
        public DbSet<Account> Accounts{ get; set; }
    }
}