﻿// <auto-generated />
using System;
using HazaRPG.Api.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HazaRPG.Api.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HazaRPG.Api.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Aggro")
                        .HasColumnType("int");

                    b.Property<int>("ArtifactEquipmentId")
                        .HasColumnType("int");

                    b.Property<int>("Attack")
                        .HasColumnType("int");

                    b.Property<int>("AttackEquipmentId")
                        .HasColumnType("int");

                    b.Property<int>("Defense")
                        .HasColumnType("int");

                    b.Property<int>("DefenseEquipmentId")
                        .HasColumnType("int");

                    b.Property<int>("Dodge")
                        .HasColumnType("int");

                    b.Property<int>("Health")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Stamina")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArtifactEquipmentId")
                        .IsUnique();

                    b.HasIndex("AttackEquipmentId")
                        .IsUnique();

                    b.HasIndex("DefenseEquipmentId")
                        .IsUnique();

                    b.ToTable("Characters", (string)null);
                });

            modelBuilder.Entity("HazaRPG.Api.Models.Dice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DiceType")
                        .HasColumnType("int")
                        .HasColumnName("DiceType");

                    b.Property<int?>("EquipmentActionId")
                        .HasColumnType("int");

                    b.Property<string>("Faces")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Faces");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentActionId");

                    b.ToTable("Dices", (string)null);
                });

            modelBuilder.Entity("HazaRPG.Api.Models.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Equipments", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("Equipment");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("HazaRPG.Api.Models.EquipmentAction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<int>("Stamina")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentId");

                    b.ToTable("EquipmentActions");
                });

            modelBuilder.Entity("HazaRPG.Api.Models.ArtifactEquipment", b =>
                {
                    b.HasBaseType("HazaRPG.Api.Models.Equipment");

                    b.HasDiscriminator().HasValue("ArtifactEquipment");
                });

            modelBuilder.Entity("HazaRPG.Api.Models.AttackEquipment", b =>
                {
                    b.HasBaseType("HazaRPG.Api.Models.Equipment");

                    b.HasDiscriminator().HasValue("AttackEquipment");
                });

            modelBuilder.Entity("HazaRPG.Api.Models.DefenseEquipment", b =>
                {
                    b.HasBaseType("HazaRPG.Api.Models.Equipment");

                    b.HasDiscriminator().HasValue("DefenseEquipment");
                });

            modelBuilder.Entity("HazaRPG.Api.Models.Character", b =>
                {
                    b.HasOne("HazaRPG.Api.Models.ArtifactEquipment", "ArtifactEquipment")
                        .WithOne()
                        .HasForeignKey("HazaRPG.Api.Models.Character", "ArtifactEquipmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HazaRPG.Api.Models.AttackEquipment", "AttackEquipment")
                        .WithOne()
                        .HasForeignKey("HazaRPG.Api.Models.Character", "AttackEquipmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HazaRPG.Api.Models.DefenseEquipment", "DefenseEquipment")
                        .WithOne()
                        .HasForeignKey("HazaRPG.Api.Models.Character", "DefenseEquipmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ArtifactEquipment");

                    b.Navigation("AttackEquipment");

                    b.Navigation("DefenseEquipment");
                });

            modelBuilder.Entity("HazaRPG.Api.Models.Dice", b =>
                {
                    b.HasOne("HazaRPG.Api.Models.EquipmentAction", null)
                        .WithMany("Dices")
                        .HasForeignKey("EquipmentActionId");
                });

            modelBuilder.Entity("HazaRPG.Api.Models.EquipmentAction", b =>
                {
                    b.HasOne("HazaRPG.Api.Models.Equipment", null)
                        .WithMany("EquipmentActions")
                        .HasForeignKey("EquipmentId");
                });

            modelBuilder.Entity("HazaRPG.Api.Models.Equipment", b =>
                {
                    b.Navigation("EquipmentActions");
                });

            modelBuilder.Entity("HazaRPG.Api.Models.EquipmentAction", b =>
                {
                    b.Navigation("Dices");
                });
#pragma warning restore 612, 618
        }
    }
}
