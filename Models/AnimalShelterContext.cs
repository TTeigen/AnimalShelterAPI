using Microsoft.EntityFrameworkCore;

namespace AnimalShelterAPI.Models
{
    public class AnimalShelterAPIContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"server=localhost;userid=root;password=epicodus;port=3306;database=AnimalShelterAPI;");

        public AnimalShelterAPIContext(DbContextOptions options) : base(options)
        {

        }
    }
}