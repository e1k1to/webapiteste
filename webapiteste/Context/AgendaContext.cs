using Microsoft.EntityFrameworkCore;
using webapiteste.Entities;

namespace webapiteste.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options ) : base(options){}

        public DbSet<Contato> Contatos { get; set; }


    }
}
