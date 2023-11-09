﻿using AkarSoftware.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.DataAccess.Concrete.EntityFramework.Configuration
{
    public class AdvertimesmentUserConfiguration : IEntityTypeConfiguration<AdvertiesmentUser>
    {
        public void Configure(EntityTypeBuilder<AdvertiesmentUser> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=> x.CoverLetter).HasMaxLength(400);
            builder.Property(x => x.WorkExperiance).HasPrecision(0,100); // Range gibi aralık belirtir
            builder.Property(x => x.WorkExperiance).HasPrecision(0, 100); // Range gibi aralık belirtir
            builder.Property(x => x.CvPath).HasColumnType("nvarchar(MAX)");
            builder.HasOne(x => x.ApplyUser).WithMany().HasForeignKey(x=> x.AppUserId);
            builder.HasOne(x => x.Advertiesment).WithMany(x => x.AdvertiesmentUsers).HasForeignKey(x => x.AdvertiesmentId);
            builder.HasOne(x => x.advertiesmentUserApplyStatus).WithMany(x => x.AdvertiesmentUsers).HasForeignKey(x => x.AdvertiesmentUserApplyStatusId);
            builder.HasOne(x => x.MilitaryStatus).WithMany(x => x.AdvertiesmentUsers).HasForeignKey(x => x.MilitaryStatusId);


        }
    }
}
