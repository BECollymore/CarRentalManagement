using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entity
{
    public class ModelSeedConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
               new Model
               {
                   Id = 1,
                   DateCreated = DateTime.Now,
                   CreatedBy = "System",
                   DateUpdated = DateTime.Now,
                   UpdatedBy = "System",
                   Name = "Prius",
               },
               new Model
               {
                   Id=2,
                   DateCreated = DateTime.Now,
                   CreatedBy = "System",
                   DateUpdated = DateTime.Now,
                   UpdatedBy = "System",
                   Name = "3 Series",
               },
               new Model
               {
                    Id=3,
                    DateCreated = DateTime.Now,
                    CreatedBy = "System",
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System",
                    Name = "X5",
               }
            );
        }
    }
}
