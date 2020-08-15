using Microsoft.EntityFrameworkCore;

namespace ChatService.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Chat> Chats { get; set; }
        public DbSet<Chat_privado> Chats_privados { get; set; }
        public DbSet<Mensaje> Mensajes { get; set; }
    }
}