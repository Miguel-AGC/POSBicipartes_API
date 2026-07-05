using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POSBicipartes.Domain.Entities;
using POSBicipartes.Infrastructure.Persistence.Configurations;

public class SystemConfigurationConfiguration
    : BaseEntityConfiguration<SystemConfiguration>
{
    public override void Configure(EntityTypeBuilder<SystemConfiguration> builder)
    {
        base.Configure(builder);

        builder.ToTable("system_configuration");

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
    }
}