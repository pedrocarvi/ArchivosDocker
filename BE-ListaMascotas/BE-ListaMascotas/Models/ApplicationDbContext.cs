using Microsoft.EntityFrameworkCore;

namespace BE_ListaMascotas.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Mascota> Mascotas { get; set; }
    }
}
