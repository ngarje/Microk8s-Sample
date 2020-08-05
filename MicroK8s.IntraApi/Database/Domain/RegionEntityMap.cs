using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MicroK8s.Api.Database.Domain
{
    public sealed class RegionEntityMap : IEntityTypeConfiguration<RegionEntity>
    {
        public void Configure(EntityTypeBuilder<RegionEntity> builder)
        {
            builder.ToTable("Regions", "Mdm");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Code).IsRequired().HasMaxLength(5);
        }
    }
}
