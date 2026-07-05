namespace POSBicipartes.Domain.Entities;

using POSBicipartes.Domain.Common;

public class SystemConfiguration : AuditableEntity
{
    public required string BusinessName { get; set; }

    public string? TradeName { get; set; }

    public string? OwnerName { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? TaxId { get; set; }

    public string? LogoPath { get; set; }

    public string Currency { get; set; } = "MXN";

    public decimal TaxPercentage { get; set; } = 16m;
}