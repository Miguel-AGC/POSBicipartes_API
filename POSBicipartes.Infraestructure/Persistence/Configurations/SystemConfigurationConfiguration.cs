using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POSBicipartes.Domain.Entities;

namespace POSBicipartes.Infrastructure.Persistence.Configurations;

public class SystemConfigurationConfiguration : IEntityTypeConfiguration<SystemConfiguration>
{
    public void Configure(EntityTypeBuilder<SystemConfiguration> builder)
    {
        builder.ToTable("system_configuration");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.BusinessName)
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(x => x.TradeName)
            .HasMaxLength(150);

        builder.Property(x => x.OwnerName)
            .HasMaxLength(150);

        builder.Property(x => x.Address)
            .HasMaxLength(300);

        builder.Property(x => x.Phone)
            .HasMaxLength(20);

        builder.Property(x => x.Email)
            .HasMaxLength(100);

        builder.Property(x => x.TaxId)
            .HasMaxLength(30);

        builder.Property(x => x.LogoPath)
            .HasMaxLength(300);

        builder.Property(x => x.Currency)
            .HasMaxLength(5)
            .HasDefaultValue("MXN");

        builder.Property(x => x.TaxPercentage)
            .HasPrecision(5, 2);

        builder.Property(x => x.CreatedAt)
            .IsRequired();

        builder.Property(x => x.IsActive)
            .HasDefaultValue(true);
    }
}