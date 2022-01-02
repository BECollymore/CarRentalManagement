using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entity
{
    public class ColorSeedConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasData(
               new Color
               {
                   DateCreated = DateTime.Now,
                   CreatedBy = "System",
                   DateUpdated = DateTime.Now,
                   UpdatedBy= "System",
                   Name = "Black",
                   Id =1
               },
               new Color
               {
                   DateCreated = DateTime.Now,
                   CreatedBy = "System",
                   DateUpdated = DateTime.Now,
                   UpdatedBy = "System",
                   Name = "Blue",
                   Id=2
               }
            );
        }
    }

}
