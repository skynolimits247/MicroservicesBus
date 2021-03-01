using MicroservicesBus.User.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroservicesBus.User.Data.Context
{
    public static class ModelBuilderExtensions 
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserProfile>().HasData(
                 new UserProfile
                 {
                     Id = 1,
                     UserName = "testOne",
                     FirstMidName = "testOne",
                     LastName = "testOne",
                     Email = "testOne@gmail.com",
                     PhoneNumber = "999999999",
                     AreaOfCoverage = "110011",
                     Specialization = "Plumber",
                     Role = UserType.serviceprovider,
                     Gender = Gender.male,
                     NumberOfAppointments = 9
                 },
                 new UserProfile
                 {
                     Id = 2,
                     UserName = "testTwo",
                     FirstMidName = "testTwo",
                     LastName = "testTwo",
                     Email = "testTwo@gmail.com",
                     PhoneNumber = "1234567890",
                     AreaOfCoverage = "110011",
                     Specialization = "Electrician",
                     Role = UserType.serviceprovider,
                     Gender = Gender.female,
                     NumberOfAppointments = 0
                 },
                 new UserProfile
                 {
                     Id = 3,
                     UserName = "testThree",
                     FirstMidName = "testThree",
                     LastName = "testThree",
                     Email = "testThree@gmail.com",
                     PhoneNumber = "9102837465",
                     AreaOfCoverage = "110011",
                     Specialization = "Mechanic",
                     Role = UserType.serviceprovider,
                     Gender = Gender.male,
                     NumberOfAppointments = 0
                 },
                 new UserProfile
                 {
                     Id = 4,
                     UserName = "testFour",
                     FirstMidName = "testFour",
                     LastName = "testFour",
                     Email = "testFour@gmail.com",
                     PhoneNumber = "999888999",
                     AreaOfCoverage = "110011",
                     Specialization = "Carpenter",
                     Role = UserType.serviceprovider,
                     Gender = Gender.male,
                     NumberOfAppointments = 0
                 }
             );
        }
    }
}
