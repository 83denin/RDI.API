using Microsoft.EntityFrameworkCore;
using RDI.BIBLIOTECA.Domain;

namespace RDI.BIBLIOTECA.GeladeiraContext
{
    public class GeladeiraDbContext : DbContext
    {

        public GeladeiraDbContext(DbContextOptions<GeladeiraDbContext> options) : base(options)
        {
        }
        public DbSet<Item> Itens { get; set; }

    }
}
