using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entity
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            //add user and role using guid values
            builder.HasData(
                 new IdentityUserRole<string> { 
                     RoleId = "8c9e6000-7425-40de-933b-e07ff1f90ae8",
                     UserId = "9c9e7005-7425-41de-933b-e07ff1e90ae9"
                 },
                 new IdentityUserRole<string>
                 {
                     RoleId = "7c9e6679-7425-40de-944b-e07fc1f90ae7",
                     UserId = "5c9e7d05-7425-45de-933b-e07effe90ae5"
                 }
            );
        }
    }
}
