using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace lab2.model.city
{
    public class cityConfigration : IEntityTypeConfiguration<city>
    {
        

        public void Configure(EntityTypeBuilder<city> builder)
        {
            builder.ToTable("city");
            builder.HasKey(i => i.ID);
            builder.Property(i => i.ID).ValueGeneratedOnAdd();
        }
    }
}
