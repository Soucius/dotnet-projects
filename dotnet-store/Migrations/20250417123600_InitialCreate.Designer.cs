﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnet_store.Models;

#nullable disable

namespace dotnet_store.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250417123600_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.4");

            modelBuilder.Entity("dotnet_store.Models.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Aktif")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Fiyat")
                        .HasColumnType("REAL");

                    b.Property<string>("UrunAdi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Urunler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Aktif = false,
                            Fiyat = 10000.0,
                            UrunAdi = "Apple Watch 7"
                        },
                        new
                        {
                            Id = 2,
                            Aktif = true,
                            Fiyat = 20000.0,
                            UrunAdi = "Apple Watch 8"
                        },
                        new
                        {
                            Id = 3,
                            Aktif = true,
                            Fiyat = 30000.0,
                            UrunAdi = "Apple Watch 9"
                        },
                        new
                        {
                            Id = 4,
                            Aktif = false,
                            Fiyat = 40000.0,
                            UrunAdi = "Apple Watch 10"
                        },
                        new
                        {
                            Id = 5,
                            Aktif = true,
                            Fiyat = 50000.0,
                            UrunAdi = "Apple Watch 11"
                        },
                        new
                        {
                            Id = 6,
                            Aktif = true,
                            Fiyat = 60000.0,
                            UrunAdi = "Apple Watch 12"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
