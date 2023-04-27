using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace lab2.model.continent
{
    public class contenentConfigration : IEntityTypeConfiguration<continent>
    {
        

        public void Configure(EntityTypeBuilder<continent> builder)
        {
            builder.ToTable("continent");
            builder.HasKey(i => i.ID);
            builder.Property(i => i.ID).IsRequired().ValueGeneratedOnAdd();
            builder.Property(i => i.Name).IsRequired();
        }
    }
}
