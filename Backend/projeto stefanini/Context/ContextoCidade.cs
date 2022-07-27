using Microsoft.EntityFrameworkCore;
using projeto_stefanini.model;

namespace projeto_stefanini.Context
{
    public class ContextoCidade:DbContext
    {
        public DbSet<Cidade> cidades { get; set; }
        public ContextoCidade(DbContextOptions<ContextoCidade> options) : base(options)
        {

        }

    }
    
}
