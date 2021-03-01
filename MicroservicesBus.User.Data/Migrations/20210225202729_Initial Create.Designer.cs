﻿// <auto-generated />
using MicroservicesBus.User.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MicroservicesBus.User.Data.Migrations
{
    [DbContext(typeof(UserProfileDbContext))]
    [Migration("20210225202729_Initial Create")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MicroservicesBus.User.Domain.Models.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AreaOfCoverage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstMidName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfAppointments")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Specialization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserProfiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AreaOfCoverage = "110011",
                            Email = "testOne@gmail.com",
                            FirstMidName = "testOne",
                            Gender = 1,
                            LastName = "testOne",
                            NumberOfAppointments = 9,
                            PhoneNumber = "999999999",
                            Role = 3,
                            Specialization = "Plumber",
                            UserName = "testOne"
                        },
                        new
                        {
                            Id = 2,
                            AreaOfCoverage = "110011",
                            Email = "testTwo@gmail.com",
                            FirstMidName = "testTwo",
                            Gender = 2,
                            LastName = "testTwo",
                            NumberOfAppointments = 0,
                            PhoneNumber = "1234567890",
                            Role = 3,
                            Specialization = "Electrician",
                            UserName = "testTwo"
                        },
                        new
                        {
                            Id = 3,
                            AreaOfCoverage = "110011",
                            Email = "testThree@gmail.com",
                            FirstMidName = "testThree",
                            Gender = 1,
                            LastName = "testThree",
                            NumberOfAppointments = 0,
                            PhoneNumber = "9102837465",
                            Role = 3,
                            Specialization = "Mechanic",
                            UserName = "testThree"
                        },
                        new
                        {
                            Id = 4,
                            AreaOfCoverage = "110011",
                            Email = "testFour@gmail.com",
                            FirstMidName = "testFour",
                            Gender = 1,
                            LastName = "testFour",
                            NumberOfAppointments = 0,
                            PhoneNumber = "999888999",
                            Role = 3,
                            Specialization = "Carpenter",
                            UserName = "testFour"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}