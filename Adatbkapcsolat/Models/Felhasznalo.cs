using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Adatbkapcsolat.Models
{
    public class Felhasznalo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public string Email { get; set; }

    }
}
