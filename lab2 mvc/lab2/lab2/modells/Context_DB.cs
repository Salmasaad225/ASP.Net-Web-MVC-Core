using lab2.model.city;
using lab2.model.continent;
using lab2.model.country;
using Microsoft.EntityFrameworkCore;


namespace lab2.model
{
    public class Context_DB :DbContext
    {

        public DbSet<model.country.country> countries { get; set; }
        public DbSet<model.continent.continent> continents { get; set; }
        public DbSet<model.city.city> cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new cityConfigration().Configure(modelBuilder.Entity<model.city.city>());
            new countryConfigration().Configure(modelBuilder.Entity<model.country.country>());
            new contenentConfigration().Configure(modelBuilder.Entity<model.continent.continent>());
            
            modelBuilder.MapRelationship();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
               "Data Source=DESKTOP-P73CSRJ\\SQLEXPRESS;Initial Catalog=lab2;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;");
        }
    }
}
