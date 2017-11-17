using financa_domain;
using Microsoft.EntityFrameworkCore;

namespace financa_repository
{
    public class DataContext : DbContext
    {
        
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public DbSet<Despesa> Despesas { get; set; }
        public DbSet<TipoDespesa> TiposDespesas {get; set;}
    }
}