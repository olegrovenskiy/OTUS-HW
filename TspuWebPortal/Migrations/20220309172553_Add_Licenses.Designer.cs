﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TspuWebPortal.Data;

#nullable disable

namespace TspuWebPortal.Migrations
{
    [DbContext(typeof(AllDbContext))]
    [Migration("20220309172553_Add_Licenses")]
    partial class Add_Licenses
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TspuWebPortal.Data.CableData", b =>
                {
                    b.Property<int>("CableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CableId"));

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("DeliveryYear")
                        .HasColumnType("integer");

                    b.Property<int>("DetailTransferId")
                        .HasColumnType("integer");

                    b.Property<int>("EntityModelId")
                        .HasColumnType("integer");

                    b.Property<string>("InventoryNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsInstalled")
                        .HasColumnType("boolean");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PrimaryRecordlId")
                        .HasColumnType("integer");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SnType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CableId");

                    b.HasIndex("EntityModelId");

                    b.ToTable("Cables");
                });

            modelBuilder.Entity("TspuWebPortal.Data.CardData", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CardId"));

                    b.Property<string>("CardSlotInChassis")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CardStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ChassisId")
                        .HasColumnType("integer");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("DeliveryYear")
                        .HasColumnType("integer");

                    b.Property<int>("DetailTransferId")
                        .HasColumnType("integer");

                    b.Property<int>("EntityModelId")
                        .HasColumnType("integer");

                    b.Property<string>("InventoryNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsInstalled")
                        .HasColumnType("boolean");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PrimaryRecordlId")
                        .HasColumnType("integer");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SnType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CardId");

                    b.HasIndex("ChassisId");

                    b.HasIndex("EntityModelId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("TspuWebPortal.Data.ChassisData", b =>
                {
                    b.Property<int>("ChassisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ChassisId"));

                    b.Property<string>("ChassisStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CurrentLocation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("DeliveryYear")
                        .HasColumnType("integer");

                    b.Property<int>("DetailTransferId")
                        .HasColumnType("integer");

                    b.Property<int>("EntityModelId")
                        .HasColumnType("integer");

                    b.Property<string>("Hostname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("InventoryNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsInstalled")
                        .HasColumnType("boolean");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PrimaryRecordlId")
                        .HasColumnType("integer");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SnType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ChassisId");

                    b.HasIndex("EntityModelId");

                    b.ToTable("Chassis");
                });

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

            modelBuilder.Entity("TspuWebPortal.Data.EntityModelData", b =>
                {
                    b.Property<int>("EntityModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EntityModelId"));

                    b.Property<int>("MaximalPower")
                        .HasColumnType("integer");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ModelType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NominalPower")
                        .HasColumnType("integer");

                    b.Property<string>("PartNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Vendor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("EntityModelId");

                    b.ToTable("EntityModel");
                });

            modelBuilder.Entity("TspuWebPortal.Data.LicenseData", b =>
                {
                    b.Property<int>("LicenseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LicenseId"));

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("DeliveryYear")
                        .HasColumnType("integer");

                    b.Property<int>("EntityModelId")
                        .HasColumnType("integer");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PrimaryRecordlId")
                        .HasColumnType("integer");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SnType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LicenseId");

                    b.HasIndex("EntityModelId");

                    b.ToTable("Licenses");
                });

            modelBuilder.Entity("TspuWebPortal.Data.ModuleData", b =>
                {
                    b.Property<int>("ModuleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ModuleId"));

                    b.Property<int>("CardId")
                        .HasColumnType("integer");

                    b.Property<string>("CardSlotInChassisOrCard")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ChassisId")
                        .HasColumnType("integer");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("DeliveryYear")
                        .HasColumnType("integer");

                    b.Property<int>("DetailTransferId")
                        .HasColumnType("integer");

                    b.Property<int>("EntityModelId")
                        .HasColumnType("integer");

                    b.Property<string>("InventoryNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsInstalled")
                        .HasColumnType("boolean");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ModuleStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PrimaryRecordlId")
                        .HasColumnType("integer");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ServeroMesto")
                        .HasColumnType("integer");

                    b.Property<string>("SnType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ModuleId");

                    b.HasIndex("CardId");

                    b.HasIndex("ChassisId");

                    b.HasIndex("EntityModelId");

                    b.ToTable("Modules");
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

            modelBuilder.Entity("TspuWebPortal.Data.ServerLinkData", b =>
                {
                    b.Property<int>("ServerLinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ServerLinkId"));

                    b.Property<int>("ServerSlotId")
                        .HasColumnType("integer");

                    b.Property<int?>("ServerSlotsServerSlotId")
                        .HasColumnType("integer");

                    b.Property<int>("ServerTypeId")
                        .HasColumnType("integer");

                    b.HasKey("ServerLinkId");

                    b.HasIndex("ServerSlotsServerSlotId");

                    b.ToTable("ServerLinks");
                });

            modelBuilder.Entity("TspuWebPortal.Data.ServerSlotData", b =>
                {
                    b.Property<int>("ServerSlotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ServerSlotId"));

                    b.Property<string>("SlotIndex")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UnitId")
                        .HasColumnType("integer");

                    b.HasKey("ServerSlotId");

                    b.ToTable("ServerSlots");
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

            modelBuilder.Entity("TspuWebPortal.Data.UnitData", b =>
                {
                    b.Property<int>("UnitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UnitId"));

                    b.Property<int>("ChassisId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsFront")
                        .HasColumnType("boolean");

                    b.Property<int>("RackId")
                        .HasColumnType("integer");

                    b.Property<string>("RowNameAsbi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RowNameDataCenter")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ServerSlotId")
                        .HasColumnType("integer");

                    b.Property<int>("UnitInRack")
                        .HasColumnType("integer");

                    b.HasKey("UnitId");

                    b.HasIndex("ChassisId");

                    b.HasIndex("RackId");

                    b.HasIndex("ServerSlotId");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("TspuWebPortal.Data.CableData", b =>
                {
                    b.HasOne("TspuWebPortal.Data.EntityModelData", "EntityModel")
                        .WithMany("Cables")
                        .HasForeignKey("EntityModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntityModel");
                });

            modelBuilder.Entity("TspuWebPortal.Data.CardData", b =>
                {
                    b.HasOne("TspuWebPortal.Data.ChassisData", "Chassis")
                        .WithMany("Cards")
                        .HasForeignKey("ChassisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TspuWebPortal.Data.EntityModelData", "EntityModel")
                        .WithMany("Cards")
                        .HasForeignKey("EntityModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chassis");

                    b.Navigation("EntityModel");
                });

            modelBuilder.Entity("TspuWebPortal.Data.ChassisData", b =>
                {
                    b.HasOne("TspuWebPortal.Data.EntityModelData", "EntityModel")
                        .WithMany("Chassis")
                        .HasForeignKey("EntityModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntityModel");
                });

            modelBuilder.Entity("TspuWebPortal.Data.LicenseData", b =>
                {
                    b.HasOne("TspuWebPortal.Data.EntityModelData", "EntityModel")
                        .WithMany("Licenses")
                        .HasForeignKey("EntityModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntityModel");
                });

            modelBuilder.Entity("TspuWebPortal.Data.ModuleData", b =>
                {
                    b.HasOne("TspuWebPortal.Data.CardData", "Card")
                        .WithMany("Modules")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TspuWebPortal.Data.ChassisData", "Chassis")
                        .WithMany("Modules")
                        .HasForeignKey("ChassisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TspuWebPortal.Data.EntityModelData", "EntityModel")
                        .WithMany("Modules")
                        .HasForeignKey("EntityModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("Chassis");

                    b.Navigation("EntityModel");
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

            modelBuilder.Entity("TspuWebPortal.Data.ServerLinkData", b =>
                {
                    b.HasOne("TspuWebPortal.Data.ServerSlotData", "ServerSlots")
                        .WithMany("ServerLinks")
                        .HasForeignKey("ServerSlotsServerSlotId");

                    b.Navigation("ServerSlots");
                });

            modelBuilder.Entity("TspuWebPortal.Data.UnitData", b =>
                {
                    b.HasOne("TspuWebPortal.Data.ChassisData", "Chassis")
                        .WithMany("Units")
                        .HasForeignKey("ChassisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TspuWebPortal.Data.RackData", "Rack")
                        .WithMany("Rows")
                        .HasForeignKey("RackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TspuWebPortal.Data.ServerSlotData", "ServerSlot")
                        .WithMany("Units")
                        .HasForeignKey("ServerSlotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chassis");

                    b.Navigation("Rack");

                    b.Navigation("ServerSlot");
                });

            modelBuilder.Entity("TspuWebPortal.Data.CardData", b =>
                {
                    b.Navigation("Modules");
                });

            modelBuilder.Entity("TspuWebPortal.Data.ChassisData", b =>
                {
                    b.Navigation("Cards");

                    b.Navigation("Modules");

                    b.Navigation("Units");
                });

            modelBuilder.Entity("TspuWebPortal.Data.DataCenterData", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("TspuWebPortal.Data.EntityModelData", b =>
                {
                    b.Navigation("Cables");

                    b.Navigation("Cards");

                    b.Navigation("Chassis");

                    b.Navigation("Licenses");

                    b.Navigation("Modules");
                });

            modelBuilder.Entity("TspuWebPortal.Data.RackData", b =>
                {
                    b.Navigation("Rows");
                });

            modelBuilder.Entity("TspuWebPortal.Data.RoomData", b =>
                {
                    b.Navigation("Rows");
                });

            modelBuilder.Entity("TspuWebPortal.Data.RowData", b =>
                {
                    b.Navigation("Rows");
                });

            modelBuilder.Entity("TspuWebPortal.Data.ServerSlotData", b =>
                {
                    b.Navigation("ServerLinks");

                    b.Navigation("Units");
                });
#pragma warning restore 612, 618
        }
    }
}
