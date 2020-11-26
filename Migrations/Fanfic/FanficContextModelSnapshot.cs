﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using fanfic.by.Models;

namespace fanfic.by.Migrations.Fanfic
{
    [DbContext(typeof(FanficContext))]
    partial class FanficContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("fanfic.by.Models.Fanfic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<int?>("ImageFanficId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("kolLikes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.HasIndex("ImageFanficId");

                    b.ToTable("Fanfics");
                });

            modelBuilder.Entity("fanfic.by.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("fanfic.by.Models.ImageFanfic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("fanfic.by.Models.Like", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdFanfic")
                        .HasColumnType("int");

                    b.Property<string>("IdUser")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("fanfic.by.Models.Fanfic", b =>
                {
                    b.HasOne("fanfic.by.Models.Genre", "Genre")
                        .WithMany("Fanfics")
                        .HasForeignKey("GenreId");

                    b.HasOne("fanfic.by.Models.ImageFanfic", "ImageFanfic")
                        .WithMany()
                        .HasForeignKey("ImageFanficId");
                });
#pragma warning restore 612, 618
        }
    }
}
