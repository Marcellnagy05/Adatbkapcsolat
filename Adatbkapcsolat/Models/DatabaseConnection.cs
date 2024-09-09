using Microsoft.EntityFrameworkCore;

namespace Adatbkapcsolat.Models
{
    public class DatabaseConnection : DbContext
    {
        public DatabaseConnection
            (DbContextOptions<DatabaseConnection> options) : base(options)
        {

        }
    }
}
