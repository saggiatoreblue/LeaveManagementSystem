using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementSystem.Data.Configurations;

public class IdentityUserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
    {
        builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "e9f639de-624f-4a4e-b8bf-2381725462f1",
                UserId = "408aa945-3d84-4421-8342-7269ec64d949"
            });
        builder.HasData(
             new IdentityUserRole<string>
             {
                 RoleId = "cc4fcb01-de88-4c20-b4ac-8df5c2a65160",
                 UserId = "1662c23d-0375-4a1f-b8a3-f0c4644ea30e"
             });
        builder.HasData(
             new IdentityUserRole<string>
             {
                 RoleId = "6d9ed3ff-bebb-42bc-ad07-0255bb0f7edb",
                 UserId = "ce781dc3-4c3c-44e9-a426-70820115356c"
             });
    }

}
