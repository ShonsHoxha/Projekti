﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetagogetdheDepartamenti.data;

#nullable disable

namespace PetagogetdheDepartamenti.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230501120406_DdheP")]
    partial class DdheP
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PetagogetdheDepartamenti.data.Models.Departament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmriD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departamentet");
                });

            modelBuilder.Entity("PetagogetdheDepartamenti.data.Models.Petagog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DEP")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartamentId")
                        .HasColumnType("int");

                    b.Property<string>("Emer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lenda")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mbiemer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentId");

                    b.ToTable("Petagoget");
                });

            modelBuilder.Entity("PetagogetdheDepartamenti.data.Models.Petagog", b =>
                {
                    b.HasOne("PetagogetdheDepartamenti.data.Models.Departament", null)
                        .WithMany("Petagoget")
                        .HasForeignKey("DepartamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PetagogetdheDepartamenti.data.Models.Departament", b =>
                {
                    b.Navigation("Petagoget");
                });
#pragma warning restore 612, 618
        }
    }
}
