using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMS.Server.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "59f8bfc3-7462-4014-8fa3-7a9a21618375",
                    Name = "User",
                    NormalizedName = "USER"
                },
                new IdentityRole
                {
                    Id = "f65e480f-49a4-4100-90f5-34de00714496",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                }
                );
            

        }
    }
}
