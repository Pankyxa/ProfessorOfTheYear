using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProfessorOfTheYear.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ApplicationForm> Forms { get; set; }
        public DbSet<ApplicationVote> Votes { get; set; }
        public DbSet<ApplicationFile> Files { get; set; }
        public DbSet<ApplicationType> Types { get; set; }
        public DbSet<ApplicationFileType> FileTypes { get; set; }
    }
}