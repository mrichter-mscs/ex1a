using Microsoft.EntityFrameworkCore;
using Microsoft_Studio.Models;


namespace Microsoft_Studio.Data
{


    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Employee> Enrollments { get; set; }
        public DbSet<Business> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            modelBuilder.Entity<Product>(entity =>
            {
           
             entity.HasKey(p => p.ProdId);
            });
            modelBuilder.Entity<Product>().ToTable("Product");
            //----
            modelBuilder.Entity<Business>(entity =>
            {         
            entity.HasKey(b => b.BusinessId);
            });
            modelBuilder.Entity<Business>().ToTable("Business");
            //----
            modelBuilder.Entity<Employee>(entity =>
            {
          
            entity.HasKey(e => e.EmpId);
            });
            modelBuilder.Entity<Employee>().ToTable("Employee");
        }
    }
}
