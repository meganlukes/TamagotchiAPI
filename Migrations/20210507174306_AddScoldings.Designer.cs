﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TamagotchiAPI.Models;

namespace TamagotchiAPI.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210507174306_AddScoldings")]
    partial class AddScoldings
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("TamagotchiAPI.Models.Feedings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("PetID")
                        .HasColumnType("integer");

                    b.Property<int?>("PetsId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("When")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("PetsId");

                    b.ToTable("Feedings");
                });

            modelBuilder.Entity("TamagotchiAPI.Models.Pets", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("HappinessLevel")
                        .HasColumnType("integer");

                    b.Property<int>("HungerLevel")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("TamagotchiAPI.Models.Playtimes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("PetID")
                        .HasColumnType("integer");

                    b.Property<int?>("PetsId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("When")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("PetsId");

                    b.ToTable("Playtimes");
                });

            modelBuilder.Entity("TamagotchiAPI.Models.Scoldings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("PetID")
                        .HasColumnType("integer");

                    b.Property<int?>("PetsId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("When")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("PetsId");

                    b.ToTable("Scoldings");
                });

            modelBuilder.Entity("TamagotchiAPI.Models.Feedings", b =>
                {
                    b.HasOne("TamagotchiAPI.Models.Pets", "Pets")
                        .WithMany()
                        .HasForeignKey("PetsId");

                    b.Navigation("Pets");
                });

            modelBuilder.Entity("TamagotchiAPI.Models.Playtimes", b =>
                {
                    b.HasOne("TamagotchiAPI.Models.Pets", "Pets")
                        .WithMany()
                        .HasForeignKey("PetsId");

                    b.Navigation("Pets");
                });

            modelBuilder.Entity("TamagotchiAPI.Models.Scoldings", b =>
                {
                    b.HasOne("TamagotchiAPI.Models.Pets", "Pets")
                        .WithMany()
                        .HasForeignKey("PetsId");

                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}
