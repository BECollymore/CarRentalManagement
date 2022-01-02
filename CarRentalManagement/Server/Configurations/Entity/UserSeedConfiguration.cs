using CarRentalManagement.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entity
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "9c9e7005-7425-41de-933b-e07ff1e90ae9",
                    UserName = "Admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    Email ="Administrator@localhost.com",
                    NormalizedEmail = "ADMINISTRATOR@LOCALHOST.COM",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null,"P@ssword1")
                },
                new ApplicationUser
                {
                    Id = "5c9e7d05-7425-45de-933b-e07effe90ae5",
                    UserName = "user@localhost.com",
                    NormalizedUserName = "USER@LOCALHOST.COM",
                    Email = "user@localhost.com",
                    NormalizedEmail = "USER@LOCALHOST.COM",
                    FirstName = "System",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null,"P@ssword1")
                }
            );
        }
    }
}
