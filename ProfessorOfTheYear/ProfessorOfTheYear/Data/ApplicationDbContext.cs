using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProfessorOfTheYear.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        
        public DbSet<Form> Form { get; set; }
        public DbSet<File> File { get; set; }
        public DbSet<Type> Type { get; set; }
        public DbSet<File2Type> File2Type { get; set; }
        public DbSet<Vote> Vote { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Form>()
                .HasOne(f => f.User)
                .WithMany()
                .HasForeignKey(f => f.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Form>()
                .HasOne(f => f.ApproverUser)
                .WithMany()
                .HasForeignKey(f => f.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<File2Type>()
                .HasKey(ft => new { ft.FileId, ft.TypeId });

            builder.Entity<File2Type>()
                .HasOne(ft => ft.File)
                .WithMany(f => f.File2Type)
                .HasForeignKey(ft => ft.TypeId);

            builder.Entity<File2Type>()
                .HasOne(ft => ft.Type)
                .WithMany(t => t.File2Type)
                .HasForeignKey(ft => ft.TypeId);
        }
    }
}