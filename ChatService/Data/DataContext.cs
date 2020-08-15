using Microsoft.EntityFrameworkCore;

namespace ChatService.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Asistencia> Asistencias { get; set; }
        public DbSet<Participante> Participantes { get; set; }
        public DbSet<Sala> Salas { get; set; }
    }
}