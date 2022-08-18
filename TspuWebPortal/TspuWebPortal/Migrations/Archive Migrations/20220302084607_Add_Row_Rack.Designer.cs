﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TspuWebPortal.Model;
using TspuWebPortal.ORM;

#nullable disable

namespace TspuWebPortal.Migrations
{
    [DbContext(typeof(TspuDbContext))]
    [Migration("20220302084607_Add_Row_Rack")]
    partial class Add_Row_Rack
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TspuWebPortal.Data.DataCenterData", b =>
                {
                    b.Property<int>("DataCenterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DataCenterId"));

                    b.Property<string>("DataCenterAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DataCenterName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("DataCenterId");

                    b.ToTable("DataCenters");
                });

            modelBuilder.Entity("TspuWebPortal.Data.RackData", b =>
                {
                    b.Property<int>("RackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RackId"));

                    b.Property<int>("FreeServerSlotsQuantity")
                        .HasColumnType("integer");

                    b.Property<int>("InstallationYear")
                        .HasColumnType("integer");

                    b.Property<bool>("IsInstalled")
                        .HasColumnType("boolean");

                    b.Property<int>("RackHeight")
                        .HasColumnType("integer");

                    b.Property<string>("RackNameAsbi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RackNameDataCenter")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RackType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("RoomRowId")
                        .HasColumnType("integer");

                    b.Property<int>("RowId")
                        .HasColumnType("integer");

                    b.HasKey("RackId");

                    b.HasIndex("RoomRowId");

                    b.ToTable("Racks");
                });

            modelBuilder.Entity("TspuWebPortal.Data.RoomData", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RoomId"));

                    b.Property<int>("DataCenterId")
                        .HasColumnType("integer");

                    b.Property<string>("RoomCoordinates")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RoomName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("RoomId");

                    b.HasIndex("DataCenterId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("TspuWebPortal.Data.RowData", b =>
                {
                    b.Property<int>("RowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RowId"));

                    b.Property<int>("RoomId")
                        .HasColumnType("integer");

                    b.Property<string>("RowNameAsbi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RowNameDataCenter")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("RowId");

                    b.HasIndex("RoomId");

                    b.ToTable("Rows");
                });

            modelBuilder.Entity("TspuWebPortal.Data.SiteData", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FederalDistrict")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IsInProject")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Links")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MaintainanceStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Oper")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PipelineStage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RegionNumber")
                        .HasColumnType("integer");

                    b.Property<string>("SiteType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Sites");
                });

            modelBuilder.Entity("TspuWebPortal.Data.RackData", b =>
                {
                    b.HasOne("TspuWebPortal.Data.RowData", "Room")
                        .WithMany("Rows")
                        .HasForeignKey("RoomRowId");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("TspuWebPortal.Data.RoomData", b =>
                {
                    b.HasOne("TspuWebPortal.Data.DataCenterData", "DataCenter")
                        .WithMany("Rooms")
                        .HasForeignKey("DataCenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DataCenter");
                });

            modelBuilder.Entity("TspuWebPortal.Data.RowData", b =>
                {
                    b.HasOne("TspuWebPortal.Data.RoomData", "Room")
                        .WithMany("Rows")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("TspuWebPortal.Data.DataCenterData", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("TspuWebPortal.Data.RoomData", b =>
                {
                    b.Navigation("Rows");
                });

            modelBuilder.Entity("TspuWebPortal.Data.RowData", b =>
                {
                    b.Navigation("Rows");
                });
#pragma warning restore 612, 618
        }
    }
}
