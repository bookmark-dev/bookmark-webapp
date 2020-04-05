﻿// <auto-generated />
using System;
using BookMark.RestApi.Databases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookMark.RestApi.Migrations
{
    [DbContext(typeof(BookMarkDbContext))]
    [Migration("20200405094658_migration1")]
    partial class migration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookMark.RestApi.Models.Appointment", b =>
                {
                    b.Property<long>("AppointmentID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("AppointmentID");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("BookMark.RestApi.Models.Event", b =>
                {
                    b.Property<long>("EventID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("OrganizationID")
                        .HasColumnType("bigint");

                    b.HasKey("EventID");

                    b.HasIndex("OrganizationID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("BookMark.RestApi.Models.Organization", b =>
                {
                    b.Property<long>("OrganizationID")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrganizationID");

                    b.ToTable("Organizations");

                    b.HasData(
                        new
                        {
                            OrganizationID = 637216588176268060L,
                            Name = "Revature",
                            Password = "$2a$11$iJUdOFrGEqvoYE87FMO/4e1M2.YGUB4epVYYk1Z.ZAu24Hi4Pjshu"
                        });
                });

            modelBuilder.Entity("BookMark.RestApi.Models.User", b =>
                {
                    b.Property<long>("UserID")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = 1L,
                            Name = "synaodev",
                            Password = "$2a$11$QEyeGMOrJxL8KXvGrxRFnuXkPwi7eKgIyt2cWWtM9GlF9AE93N5EC"
                        });
                });

            modelBuilder.Entity("BookMark.RestApi.Models.UserAppointment", b =>
                {
                    b.Property<long>("UserAppointmentID")
                        .HasColumnType("bigint");

                    b.Property<long>("AppointmentID")
                        .HasColumnType("bigint");

                    b.Property<long>("UserID")
                        .HasColumnType("bigint");

                    b.HasKey("UserAppointmentID");

                    b.HasIndex("AppointmentID");

                    b.HasIndex("UserID");

                    b.ToTable("UserAppointment");
                });

            modelBuilder.Entity("BookMark.RestApi.Models.UserEvent", b =>
                {
                    b.Property<long>("UserEventID")
                        .HasColumnType("bigint");

                    b.Property<long>("EventID")
                        .HasColumnType("bigint");

                    b.Property<long>("UserID")
                        .HasColumnType("bigint");

                    b.HasKey("UserEventID");

                    b.HasIndex("EventID");

                    b.HasIndex("UserID");

                    b.ToTable("UserEvents");
                });

            modelBuilder.Entity("BookMark.RestApi.Models.Event", b =>
                {
                    b.HasOne("BookMark.RestApi.Models.Organization", "Organization")
                        .WithMany("Events")
                        .HasForeignKey("OrganizationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookMark.RestApi.Models.UserAppointment", b =>
                {
                    b.HasOne("BookMark.RestApi.Models.Appointment", "Appointment")
                        .WithMany("UserAppointments")
                        .HasForeignKey("AppointmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookMark.RestApi.Models.User", "User")
                        .WithMany("UserAppointments")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookMark.RestApi.Models.UserEvent", b =>
                {
                    b.HasOne("BookMark.RestApi.Models.Event", "Event")
                        .WithMany("UserEvents")
                        .HasForeignKey("EventID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookMark.RestApi.Models.User", "User")
                        .WithMany("UserEvents")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}