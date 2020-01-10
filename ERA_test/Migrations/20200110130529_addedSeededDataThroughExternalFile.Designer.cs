﻿// <auto-generated />
using System;
using ERA_test.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ERA_test.Migrations
{
    [DbContext(typeof(_DatabaseContext))]
    [Migration("20200110130529_addedSeededDataThroughExternalFile")]
    partial class addedSeededDataThroughExternalFile
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ERA_test.Models.Area", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AreaTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Priority")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AreaTypeId");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("ERA_test.Models.AreaCoordinates", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AreaId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.ToTable("AreaCoordinates");
                });

            modelBuilder.Entity("ERA_test.Models.AreaLimits", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("AreaId1")
                        .HasColumnType("integer");

                    b.Property<int>("LimitType")
                        .HasColumnType("integer");

                    b.Property<decimal>("LimitValue")
                        .HasColumnType("numeric");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("RegulationId")
                        .HasColumnType("integer");

                    b.Property<string>("Units")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AreaId1");

                    b.HasIndex("RegulationId");

                    b.ToTable("AreaLimits");
                });

            modelBuilder.Entity("ERA_test.Models.AreaRegulations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AreaId")
                        .HasColumnType("integer");

                    b.Property<int?>("RegulationId1")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.HasIndex("RegulationId1");

                    b.ToTable("AreaRegulations");
                });

            modelBuilder.Entity("ERA_test.Models.AreaType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AreaType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Emmission Area"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Discharge Area"
                        });
                });

            modelBuilder.Entity("ERA_test.Models.Regulations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("LastChanged")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Regulations");
                });

            modelBuilder.Entity("ERA_test.Models.Area", b =>
                {
                    b.HasOne("ERA_test.Models.AreaType", "AreaType")
                        .WithMany("Areas")
                        .HasForeignKey("AreaTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ERA_test.Models.AreaCoordinates", b =>
                {
                    b.HasOne("ERA_test.Models.Area", "Area")
                        .WithMany("AreaCoordinates")
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ERA_test.Models.AreaLimits", b =>
                {
                    b.HasOne("ERA_test.Models.Area", null)
                        .WithMany("AreaLimits")
                        .HasForeignKey("AreaId1");

                    b.HasOne("ERA_test.Models.Regulations", "Regulation")
                        .WithMany()
                        .HasForeignKey("RegulationId");
                });

            modelBuilder.Entity("ERA_test.Models.AreaRegulations", b =>
                {
                    b.HasOne("ERA_test.Models.Area", "Area")
                        .WithMany("Regulations")
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ERA_test.Models.Regulations", "Regulation")
                        .WithMany("AreaRegulations")
                        .HasForeignKey("RegulationId1");
                });
#pragma warning restore 612, 618
        }
    }
}
