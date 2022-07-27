using Microsoft.EntityFrameworkCore;
using projeto_stefanini.model;

namespace projeto_stefanini.Context
{
    public class ContextoPessoa:DbContext
    {
        public DbSet<Pessoa> pessoas { get; set; }
        public ContextoPessoa(DbContextOptions<ContextoPessoa> options) : base(options)
        {

        }
    }
}
