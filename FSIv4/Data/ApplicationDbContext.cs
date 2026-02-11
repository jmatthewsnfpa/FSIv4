using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FSIv4.Data.Models;

namespace FSIv4.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<FSIv4.Data.Models.FSI> FSI { get; set; } = default!;
        public DbSet<FSIv4.Data.Models.ProtectedTowns> ProtectedTowns { get; set; } = default!;
    }
}
