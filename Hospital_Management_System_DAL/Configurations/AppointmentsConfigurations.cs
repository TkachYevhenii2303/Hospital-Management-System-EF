﻿using Hospital_Management_System_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System_DAL.Configurations
{
    internal class AppointmentsConfigurations : IEntityTypeConfiguration<Appointments>
    {
        public void Configure(EntityTypeBuilder<Appointments> builder)
        {
            builder
                .HasMany(x => x.Documents)
                .WithOne(x => x.Appointments)
                .HasForeignKey(fk => fk.AppointmentsId)
                .IsRequired()
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder
                .HasMany(x => x.StatusHistories)
                .WithOne(x => x.Appointments)
                .HasForeignKey(fk => fk.AppointmentsId)
                .IsRequired()
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
