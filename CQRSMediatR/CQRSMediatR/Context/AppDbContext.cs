using CQRSMediatR.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRSMediatR.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }
        public DbSet<Produto> Produtos { get; set; }
    }
}
