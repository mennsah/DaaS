﻿// <auto-generated />
using DaaS.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DaaS.DataLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210305130847_AgentsTable")]
    partial class AgentsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DaaS.DataLayer.DataModels.Agent", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("AccountCode")
                        .HasColumnType("text");

                    b.Property<string>("AccountName")
                        .HasColumnType("text");

                    b.Property<string>("AccountNumber")
                        .HasColumnType("text");

                    b.Property<string>("AccountProvider")
                        .HasColumnType("text");

                    b.Property<string>("AccountType")
                        .HasColumnType("text");

                    b.Property<string>("Fullname")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("text");

                    b.Property<string>("MotorNumber")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Agents");
                });
#pragma warning restore 612, 618
        }
    }
}
