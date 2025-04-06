using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementSystem.Web.Data.Configurations;

public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        var hasher = new PasswordHasher<ApplicationUser>();
        builder.HasData(new ApplicationUser
        {
            Id = "408aa945-3d84-4421-8342-7269ec64d949",
            Email = "admin@localhost.com",
            NormalizedEmail = "ADMIN@LOCALHOST.COM",
            NormalizedUserName = "ADMIN@LOCALHOST.COM",
            UserName = "admin@localhost.com",
            PasswordHash = hasher.HashPassword(null, "P@ssword1"),
            EmailConfirmed = true,
            FirstName = "Default",
            LastName = "Admin",
            DateOfBirth = new DateOnly(1950, 12, 01)
        });
        builder.HasData(new ApplicationUser
        {
            Id = "1662c23d-0375-4a1f-b8a3-f0c4644ea30e",
            Email = "saggiatoreblue@gmail.com",
            NormalizedEmail = "SAGGIATOREBLUE@GMAIL.COM",
            NormalizedUserName = "SAGGIATOREBLUE@GMAIL.COM",
            UserName = "saggiatoreblue@gmail.com",
            PasswordHash = hasher.HashPassword(null, "Antimatter25!"),
            EmailConfirmed = true,
            FirstName = "Michael",
            LastName = "Botelho",
            DateOfBirth = new DateOnly(1960, 12, 01)
        });
        builder.HasData(new ApplicationUser
        {
            Id = "ce781dc3-4c3c-44e9-a426-70820115356c",
            Email = "michael.d.botelho@gmail.com",
            NormalizedEmail = "MICHAEL.D.BOTELHO@GMAIL.COM",
            NormalizedUserName = "MICHAEL.D.BOTELHO@GMAIL.COM",
            UserName = "michael.d.botelho@gmail.com",
            PasswordHash = hasher.HashPassword(null, "Antimatter25!"),
            EmailConfirmed = true,
            FirstName = "Bichael",
            LastName = "Motelho",
            DateOfBirth = new DateOnly(1970, 12, 01)
        });
    }
}