using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entity
{
    public class MakeSeedConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
                    new Make
                    {
                        Id = 1,
                        CreatedBy = "System",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        UpdatedBy = "System",
                        Name="Nissan"

                    },
                      new Make
                      {
                          Id=2,
                          CreatedBy = "System",
                          DateCreated = DateTime.Now,
                          DateUpdated = DateTime.Now,
                          UpdatedBy = "System",
                          Name = "Toyota"

                      },
                        new Make
                        {
                            Id=3,
                            CreatedBy = "System",
                            DateCreated = DateTime.Now,
                            DateUpdated = DateTime.Now,
                            UpdatedBy = "System",
                            Name = "BMW"

                        }
                );
        }
    }
}
