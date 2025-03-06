using Microsoft.EntityFrameworkCore;

namespace CharacterChronicleAPI.Models
{
    public class DandD5ECharacterContext : DbContext
    {
        public DandD5ECharacterContext(DbContextOptions<DandD5ECharacterContext> options) : base(options) 
        { 
        }

        public DbSet<DandD5ECharacter> DandD5ECharacterItems { get; set; } = null!;
    }
}
