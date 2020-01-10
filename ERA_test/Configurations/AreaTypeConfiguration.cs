using ERA_test.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERA_test.Configurations
{
    public class AreaTypeConfiguration : IEntityTypeConfiguration<AreaType>
    {
        public void Configure(EntityTypeBuilder<AreaType> builder)
        {
            builder.ToTable("AreaType");
            builder.HasData(
                    new AreaType
                    {
                        Id = 1,
                        Name = "Emmission Area",
                    },
                    new AreaType
                    {
                        Id = 2,
                        Name = "Discharge Area",
                    }
                );

        }
    }
}
