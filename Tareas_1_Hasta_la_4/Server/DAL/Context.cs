using Microsoft.EntityFrameworkCore;
using Tareas_1_Hasta_la_4.Shared;

namespace Tareas_1_Hasta_la_4.Server.DAL
{
    public class Context : DbContext
    {
        public DbSet<Prioridades> Prioridades {  get; set; }
        public Context(DbContextOptions<Context> options) : base(options){}
    }
}
