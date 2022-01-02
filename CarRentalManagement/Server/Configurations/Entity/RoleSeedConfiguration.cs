using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entity
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole { 
                    Id = "7c9e6679-7425-40de-944b-e07fc1f90ae7",
                    Name ="User",
                    NormalizedName = "USER"
                
                },
                 new IdentityRole
                 {
                     Id = "8c9e6000-7425-40de-933b-e07ff1f90ae8",
                     Name = "Administrator",
                     NormalizedName = "ADMINISTRATOR"

                 }
            );
        }
    }
}
