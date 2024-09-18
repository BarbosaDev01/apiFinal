using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class LivroContext : DbContext 
    {
        public LivroContext(DbContextOptions<LivroContext> options)
        : base(options)
        {

        }

        public DbSet<Livro> Livro { get; set; } = null!;

        public DbSet<WebApplication1.Models.Usuario> Usuario { get; set; } = default!;
    }
}
