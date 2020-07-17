using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Model;

namespace Control
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base (options) { 

            
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
    {
        base.OnModelCreating(modelbuilder);

        modelbuilder.Entity<Visit>()
            .HasOne(c => c.Evaluator)
            .WithMany(t => t.Visits)
            .HasForeignKey(c => c.EvaluatorId)
            .OnDelete(DeleteBehavior.Restrict); // no ON DELETE

        modelbuilder.Entity(typeof (Visit))
            .HasOne(typeof (Tutor), "Tutor")
            .WithMany()
            .HasForeignKey("TutorId")
            .OnDelete(DeleteBehavior.Restrict); // no ON DELETE

        
    }
        
        public DbSet<Evaluator> Evaluators{ get; set; }
        public DbSet<EconomicStudy> EconomicStudies{ get; set; }
        public DbSet<Student> Students{ get; set; }
        public DbSet<Visit> Visits{ get; set; }
        public DbSet<Tutor> Tutors{ get; set; }
        public DbSet<Account> Accounts{ get; set; }
    }
}