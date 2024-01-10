using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entities;

namespace ModuloAPI.Context
{
    public class AgendaContext : DbContext
    {
        public DbSet<Contato> Contatos { get; set; }

        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
        }
    }
}