using Microsoft.EntityFrameworkCore;
using SortFilterPageDemo.Models;

namespace SortFilterPageDemo.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
