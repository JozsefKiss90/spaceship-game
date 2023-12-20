﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SpaceShipAPI.Database;

#nullable disable

namespace SpaceShipAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231204155448_UpdateStoredResource3")]
    partial class UpdateStoredResource3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Event", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EventMessage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("EventType")
                        .HasColumnType("integer");

                    b.Property<long?>("MissionId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("MissionId");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("Level", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("Effect")
                        .HasColumnType("integer")
                        .HasColumnName("Effect");

                    b.Property<int>("LevelValue")
                        .HasColumnType("integer")
                        .HasColumnName("Level");

                    b.Property<bool>("Max")
                        .HasColumnType("boolean")
                        .HasColumnName("IsMax");

                    b.Property<int>("Type")
                        .HasColumnType("integer")
                        .HasColumnName("Type");

                    b.HasKey("Id");

                    b.ToTable("Levels");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Effect = 0,
                            LevelValue = 1,
                            Max = false,
                            Type = 0
                        },
                        new
                        {
                            Id = 2L,
                            Effect = 0,
                            LevelValue = 2,
                            Max = false,
                            Type = 0
                        },
                        new
                        {
                            Id = 3L,
                            Effect = 0,
                            LevelValue = 3,
                            Max = false,
                            Type = 0
                        },
                        new
                        {
                            Id = 4L,
                            Effect = 0,
                            LevelValue = 4,
                            Max = false,
                            Type = 0
                        },
                        new
                        {
                            Id = 5L,
                            Effect = 0,
                            LevelValue = 5,
                            Max = true,
                            Type = 0
                        },
                        new
                        {
                            Id = 11L,
                            Effect = 0,
                            LevelValue = 1,
                            Max = false,
                            Type = 1
                        },
                        new
                        {
                            Id = 12L,
                            Effect = 0,
                            LevelValue = 2,
                            Max = false,
                            Type = 1
                        },
                        new
                        {
                            Id = 13L,
                            Effect = 0,
                            LevelValue = 3,
                            Max = false,
                            Type = 1
                        },
                        new
                        {
                            Id = 14L,
                            Effect = 0,
                            LevelValue = 4,
                            Max = false,
                            Type = 1
                        },
                        new
                        {
                            Id = 15L,
                            Effect = 0,
                            LevelValue = 5,
                            Max = true,
                            Type = 1
                        },
                        new
                        {
                            Id = 21L,
                            Effect = 0,
                            LevelValue = 1,
                            Max = false,
                            Type = 2
                        },
                        new
                        {
                            Id = 22L,
                            Effect = 0,
                            LevelValue = 2,
                            Max = false,
                            Type = 2
                        },
                        new
                        {
                            Id = 23L,
                            Effect = 0,
                            LevelValue = 3,
                            Max = false,
                            Type = 2
                        },
                        new
                        {
                            Id = 24L,
                            Effect = 0,
                            LevelValue = 4,
                            Max = false,
                            Type = 2
                        },
                        new
                        {
                            Id = 25L,
                            Effect = 0,
                            LevelValue = 5,
                            Max = true,
                            Type = 2
                        },
                        new
                        {
                            Id = 31L,
                            Effect = 0,
                            LevelValue = 1,
                            Max = false,
                            Type = 3
                        },
                        new
                        {
                            Id = 32L,
                            Effect = 0,
                            LevelValue = 2,
                            Max = false,
                            Type = 3
                        },
                        new
                        {
                            Id = 33L,
                            Effect = 0,
                            LevelValue = 3,
                            Max = false,
                            Type = 3
                        },
                        new
                        {
                            Id = 34L,
                            Effect = 0,
                            LevelValue = 4,
                            Max = false,
                            Type = 3
                        },
                        new
                        {
                            Id = 35L,
                            Effect = 0,
                            LevelValue = 5,
                            Max = true,
                            Type = 3
                        },
                        new
                        {
                            Id = 41L,
                            Effect = 0,
                            LevelValue = 1,
                            Max = false,
                            Type = 4
                        },
                        new
                        {
                            Id = 42L,
                            Effect = 0,
                            LevelValue = 2,
                            Max = false,
                            Type = 4
                        },
                        new
                        {
                            Id = 43L,
                            Effect = 0,
                            LevelValue = 3,
                            Max = false,
                            Type = 4
                        },
                        new
                        {
                            Id = 44L,
                            Effect = 0,
                            LevelValue = 4,
                            Max = false,
                            Type = 4
                        },
                        new
                        {
                            Id = 45L,
                            Effect = 0,
                            LevelValue = 5,
                            Max = true,
                            Type = 4
                        },
                        new
                        {
                            Id = 51L,
                            Effect = 0,
                            LevelValue = 1,
                            Max = false,
                            Type = 5
                        },
                        new
                        {
                            Id = 52L,
                            Effect = 0,
                            LevelValue = 2,
                            Max = false,
                            Type = 5
                        },
                        new
                        {
                            Id = 53L,
                            Effect = 0,
                            LevelValue = 3,
                            Max = false,
                            Type = 5
                        },
                        new
                        {
                            Id = 54L,
                            Effect = 0,
                            LevelValue = 4,
                            Max = false,
                            Type = 5
                        },
                        new
                        {
                            Id = 55L,
                            Effect = 0,
                            LevelValue = 5,
                            Max = true,
                            Type = 5
                        },
                        new
                        {
                            Id = 61L,
                            Effect = 0,
                            LevelValue = 1,
                            Max = false,
                            Type = 6
                        },
                        new
                        {
                            Id = 62L,
                            Effect = 0,
                            LevelValue = 2,
                            Max = false,
                            Type = 6
                        },
                        new
                        {
                            Id = 63L,
                            Effect = 0,
                            LevelValue = 3,
                            Max = false,
                            Type = 6
                        },
                        new
                        {
                            Id = 64L,
                            Effect = 0,
                            LevelValue = 4,
                            Max = false,
                            Type = 6
                        },
                        new
                        {
                            Id = 65L,
                            Effect = 0,
                            LevelValue = 5,
                            Max = true,
                            Type = 6
                        });
                });

            modelBuilder.Entity("LevelCost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<long>("LevelId")
                        .HasColumnType("bigint");

                    b.Property<int>("Resource")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("LevelId");

                    b.ToTable("LevelCost");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SpaceShipAPI.Model.Location.Location", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CurrentMissionId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Discovered")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DistanceFromStation")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ResourceReserve")
                        .HasColumnType("integer");

                    b.Property<string>("ResourceType")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CurrentMissionId");

                    b.HasIndex("UserId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("SpaceShipAPI.Model.Mission.Mission", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("ActivityDurationInSecs")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ApproxEndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("CurrentObjectiveTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CurrentStatus")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("MissionType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("TravelDurationInSecs")
                        .HasColumnType("bigint");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Missions");

                    b.HasDiscriminator<string>("MissionType").HasValue("Mission");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("SpaceshipAPI.Model.Ship.SpaceShip", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("Color")
                        .HasColumnType("integer");

                    b.Property<long?>("CurrentMissionId")
                        .HasColumnType("bigint");

                    b.Property<int>("EngineLevel")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ShieldEnergy")
                        .HasColumnType("integer");

                    b.Property<int>("ShieldLevel")
                        .HasColumnType("integer");

                    b.Property<long?>("SpaceStationId")
                        .HasColumnType("bigint");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CurrentMissionId")
                        .IsUnique();

                    b.HasIndex("SpaceStationId");

                    b.HasIndex("UserId");

                    b.ToTable("spaceship");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("SpaceshipAPI.Spaceship.Model.Station.SpaceStation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("HangarLevel")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("StorageLevel")
                        .HasColumnType("integer");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("spacestation");
                });

            modelBuilder.Entity("SpaceshipAPI.UserEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<int?>("SpaceStationId")
                        .HasColumnType("integer");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("StoredResource", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<long?>("MinerShipId")
                        .HasColumnType("bigint");

                    b.Property<string>("ResourceType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("SpaceStationId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("MinerShipId");

                    b.HasIndex("SpaceStationId");

                    b.ToTable("StoredResources");
                });

            modelBuilder.Entity("MiningMission", b =>
                {
                    b.HasBaseType("SpaceShipAPI.Model.Mission.Mission");

                    b.Property<long>("LocationId")
                        .HasColumnType("bigint");

                    b.HasIndex("LocationId");

                    b.ToTable("Missions");

                    b.HasDiscriminator().HasValue("Mining");
                });

            modelBuilder.Entity("ScoutingMission", b =>
                {
                    b.HasBaseType("SpaceShipAPI.Model.Mission.Mission");

                    b.Property<long>("DiscoveredLocationId")
                        .HasColumnType("bigint");

                    b.Property<int>("Distance")
                        .HasColumnType("integer")
                        .HasColumnName("Distance");

                    b.Property<bool>("PrioritizingDistance")
                        .HasColumnType("boolean")
                        .HasColumnName("PrioritizingDistance");

                    b.Property<int>("TargetResource")
                        .HasColumnType("integer")
                        .HasColumnName("TargetResource");

                    b.HasIndex("DiscoveredLocationId");

                    b.ToTable("Missions");

                    b.HasDiscriminator().HasValue("Scouting");
                });

            modelBuilder.Entity("SpaceShipAPI.Model.Ship.MinerShip", b =>
                {
                    b.HasBaseType("SpaceshipAPI.Model.Ship.SpaceShip");

                    b.Property<int>("DrillLevel")
                        .HasColumnType("integer");

                    b.Property<int>("StorageLevel")
                        .HasColumnType("integer");

                    b.ToTable("minership");
                });

            modelBuilder.Entity("SpaceShipAPI.Model.Ship.ScoutShip", b =>
                {
                    b.HasBaseType("SpaceshipAPI.Model.Ship.SpaceShip");

                    b.Property<int>("ScannerLevel")
                        .HasColumnType("integer");

                    b.ToTable("scoutship");
                });

            modelBuilder.Entity("Event", b =>
                {
                    b.HasOne("SpaceShipAPI.Model.Mission.Mission", null)
                        .WithMany("Events")
                        .HasForeignKey("MissionId");
                });

            modelBuilder.Entity("LevelCost", b =>
                {
                    b.HasOne("Level", "Level")
                        .WithMany("Costs")
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Level");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SpaceshipAPI.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SpaceshipAPI.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SpaceshipAPI.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SpaceshipAPI.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SpaceShipAPI.Model.Location.Location", b =>
                {
                    b.HasOne("SpaceShipAPI.Model.Mission.Mission", "CurrentMission")
                        .WithMany()
                        .HasForeignKey("CurrentMissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SpaceshipAPI.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CurrentMission");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SpaceShipAPI.Model.Mission.Mission", b =>
                {
                    b.HasOne("SpaceshipAPI.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SpaceshipAPI.Model.Ship.SpaceShip", b =>
                {
                    b.HasOne("SpaceShipAPI.Model.Mission.Mission", "CurrentMission")
                        .WithOne("Ship")
                        .HasForeignKey("SpaceshipAPI.Model.Ship.SpaceShip", "CurrentMissionId");

                    b.HasOne("SpaceshipAPI.Spaceship.Model.Station.SpaceStation", "SpaceStation")
                        .WithMany("Hangar")
                        .HasForeignKey("SpaceStationId");

                    b.HasOne("SpaceshipAPI.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CurrentMission");

                    b.Navigation("SpaceStation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SpaceshipAPI.Spaceship.Model.Station.SpaceStation", b =>
                {
                    b.HasOne("SpaceshipAPI.UserEntity", "User")
                        .WithOne("SpaceStation")
                        .HasForeignKey("SpaceshipAPI.Spaceship.Model.Station.SpaceStation", "UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("StoredResource", b =>
                {
                    b.HasOne("SpaceShipAPI.Model.Ship.MinerShip", "MinerShip")
                        .WithMany("StoredResources")
                        .HasForeignKey("MinerShipId");

                    b.HasOne("SpaceshipAPI.Spaceship.Model.Station.SpaceStation", "SpaceStation")
                        .WithMany("StoredResources")
                        .HasForeignKey("SpaceStationId");

                    b.Navigation("MinerShip");

                    b.Navigation("SpaceStation");
                });

            modelBuilder.Entity("MiningMission", b =>
                {
                    b.HasOne("SpaceShipAPI.Model.Location.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("ScoutingMission", b =>
                {
                    b.HasOne("SpaceShipAPI.Model.Location.Location", "DiscoveredLocation")
                        .WithMany()
                        .HasForeignKey("DiscoveredLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DiscoveredLocation");
                });

            modelBuilder.Entity("SpaceShipAPI.Model.Ship.MinerShip", b =>
                {
                    b.HasOne("SpaceshipAPI.Model.Ship.SpaceShip", null)
                        .WithOne()
                        .HasForeignKey("SpaceShipAPI.Model.Ship.MinerShip", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SpaceShipAPI.Model.Ship.ScoutShip", b =>
                {
                    b.HasOne("SpaceshipAPI.Model.Ship.SpaceShip", null)
                        .WithOne()
                        .HasForeignKey("SpaceShipAPI.Model.Ship.ScoutShip", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Level", b =>
                {
                    b.Navigation("Costs");
                });

            modelBuilder.Entity("SpaceShipAPI.Model.Mission.Mission", b =>
                {
                    b.Navigation("Events");

                    b.Navigation("Ship")
                        .IsRequired();
                });

            modelBuilder.Entity("SpaceshipAPI.Spaceship.Model.Station.SpaceStation", b =>
                {
                    b.Navigation("Hangar");

                    b.Navigation("StoredResources");
                });

            modelBuilder.Entity("SpaceshipAPI.UserEntity", b =>
                {
                    b.Navigation("SpaceStation")
                        .IsRequired();
                });

            modelBuilder.Entity("SpaceShipAPI.Model.Ship.MinerShip", b =>
                {
                    b.Navigation("StoredResources");
                });
#pragma warning restore 612, 618
        }
    }
}
