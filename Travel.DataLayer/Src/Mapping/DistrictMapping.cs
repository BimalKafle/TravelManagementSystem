using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.DataLayer.Mapping
{
    public class DistrictMapping
    {
        //public void Configure(EntityTypeBuilder<District> builder)
        //{
        //    builder.ToTable("vehicle_category");
        //    builder.HasKey(e => e.Id);
        //    builder.Property(e => e.Id).HasColumnName("id");
        //    builder.Property(e => e.Category_Name).HasColumnName("name");
        //    builder.Property(e => e.Status).HasColumnName("status");

        //    builder.HasMany<Vehicle>(t => t.Vehicles)
        //      .WithOne(v => v.Vehicle_Category).HasForeignKey(v => v.Vehicle_CategoryId).OnDelete(DeleteBehavior.Restrict);
        //}
    }
}
