using Microsoft.EntityFrameworkCore;


namespace lab2.model
{
    public static class RELATIONS
    {

        
            public static void MapRelationship(this ModelBuilder builder)
            {
                builder.Entity<model.country.country>().HasOne(a => a.continent).
                    WithMany(a => a.country).
                    HasForeignKey(i => i.continant_ID).
                    IsRequired().OnDelete(DeleteBehavior.NoAction);

                builder.Entity<model.city.city>().HasOne(a => a.country).
                    WithMany(a => a.city).HasForeignKey(a => a.country_ID).
                    IsRequired().OnDelete(DeleteBehavior.NoAction);
            }
        
    }
}
