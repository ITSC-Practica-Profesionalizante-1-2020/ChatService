using Microsoft.EntityFrameworkCore;

namespace ChatService.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Mensaje> Mensajes { get; set; }
    }
}