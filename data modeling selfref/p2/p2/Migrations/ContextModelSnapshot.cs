﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using p2.Data;

#nullable disable

namespace p2.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("p2.Models.BreedType", b =>
                {
                    b.Property<int>("IdBreedType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdBreedType"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdBreedType");

                    b.ToTable("BreedTypes");

                    b.HasData(
                        new
                        {
                            IdBreedType = 1,
                            Description = "ddkd",
                            Name = "djdjd"
                        });
                });

            modelBuilder.Entity("p2.Models.Pet", b =>
                {
                    b.Property<int>("IdPet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPet"), 1L, 1);

                    b.Property<DateTime>("ApproximateDateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateAdopted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateRegistered")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdBreedType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("isMale")
                        .HasColumnType("bit");

                    b.HasKey("IdPet");

                    b.HasIndex("IdBreedType");

                    b.ToTable("Pets");

                    b.HasData(
                        new
                        {
                            IdPet = 1,
                            ApproximateDateOfBirth = new DateTime(2020, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateAdopted = new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRegistered = new DateTime(2021, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdBreedType = 1,
                            Name = "djjdjd",
                            isMale = false
                        });
                });

            modelBuilder.Entity("p2.Models.Voluenteer", b =>
                {
                    b.Property<int>("IdVoluenteer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVoluenteer"), 1L, 1);

                    b.Property<int>("IdSupervisor")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("StartingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdVoluenteer");

                    b.HasIndex("IdSupervisor");

                    b.ToTable("Voluenteers");

                    b.HasData(
                        new
                        {
                            IdVoluenteer = 1,
                            IdSupervisor = 1,
                            Name = "sjdj",
                            StartingDate = new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Surname = "jsjdd"
                        });
                });

            modelBuilder.Entity("p2.Models.Voluenteer_Pet", b =>
                {
                    b.Property<int>("IdPet")
                        .HasColumnType("int");

                    b.Property<int>("IdVoluenteer")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAccepted")
                        .HasColumnType("datetime2");

                    b.HasKey("IdPet", "IdVoluenteer");

                    b.HasIndex("IdVoluenteer");

                    b.ToTable("VoluenteerPets");

                    b.HasData(
                        new
                        {
                            IdPet = 1,
                            IdVoluenteer = 1,
                            DateAccepted = new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("p2.Models.Pet", b =>
                {
                    b.HasOne("p2.Models.BreedType", "BreedType")
                        .WithMany("Pets")
                        .HasForeignKey("IdBreedType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BreedType");
                });

            modelBuilder.Entity("p2.Models.Voluenteer", b =>
                {
                    b.HasOne("p2.Models.Voluenteer", "Supervisor")
                        .WithMany()
                        .HasForeignKey("IdSupervisor");

                    b.Navigation("Supervisor");
                });

            modelBuilder.Entity("p2.Models.Voluenteer_Pet", b =>
                {
                    b.HasOne("p2.Models.Pet", "Pet")
                        .WithMany("VoluenteerPets")
                        .HasForeignKey("IdPet")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("p2.Models.Voluenteer", "Voluenteer")
                        .WithMany("VoluenteerPets")
                        .HasForeignKey("IdVoluenteer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pet");

                    b.Navigation("Voluenteer");
                });

            modelBuilder.Entity("p2.Models.BreedType", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("p2.Models.Pet", b =>
                {
                    b.Navigation("VoluenteerPets");
                });

            modelBuilder.Entity("p2.Models.Voluenteer", b =>
                {
                    b.Navigation("VoluenteerPets");
                });
#pragma warning restore 612, 618
        }
    }
}
