using MicroservicesBus.Appointment.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroservicesBus.Appointment.Data.Context
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppointmentEntity>().HasData(
                new AppointmentEntity
                {
                    Id = 1,
                    AssignedTo = 2,
                    CreatedBy = 1,
                    AppointmentStatus = AppointmentStatus.created,
                    Address = "omaxe building flat 304",
                    City = "Delhi",
                    State = "Delhi",
                    Zip = "110011",
                    Description = "electric switch not working",
                    Specialization = "electrician",

                },
                new AppointmentEntity
                {
                    Id = 2,
                    AssignedTo = 4,
                    CreatedBy = 1,
                    AppointmentStatus = AppointmentStatus.created,
                    Address = "omaxe building flat 304",
                    City = "Delhi",
                    State = "Delhi",
                    Zip = "110011",
                    Description = "door fixtures are broken and latches are not fitting well",
                    Specialization = "carpenter",

                },
                new AppointmentEntity
                {
                    Id = 3,
                    AssignedTo = 3,
                    CreatedBy = 1,
                    AppointmentStatus = AppointmentStatus.created,
                    Address = "omaxe building flat 304",
                    City = "Delhi",
                    State = "Delhi",
                    Zip = "110011",
                    Description = "car needs servicing",
                    Specialization = "mechanic",

                }
                );
        }
    }
}
