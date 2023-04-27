using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace lab2.model.country
{
    public class countryConfigration : IEntityTypeConfiguration<country>
    {
       

        public void Configure(EntityTypeBuilder<country> builder)
        {
            builder.ToTable("country");
            builder.HasKey(i => i.ID);
            builder.Property(i => i.ID).ValueGeneratedOnAdd();
            builder.Property(i => i.continant_ID).IsRequired();
        }
    }
}
