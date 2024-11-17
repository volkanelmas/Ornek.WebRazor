using Microsoft.EntityFrameworkCore;

namespace Ornek.WebRazor02.Models
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyDb");
        }
        public DbSet<Person> Persons { get; set; }
    }
}
