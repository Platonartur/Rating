﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeenControl.Api.Models;

namespace TeenControl.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GirlsRanking.Girls.Teen", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("TeenId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Teens");

                    b.HasData(
                        new
                        {
                            Id = "https://vk.com/id412379471",
                            Img = "images/Amaliya.jpg",
                            ImgName = "images/Amaliya",
                            Name = "Aurora Redfield",
                            Number = 0,
                            TeenId = 1
                        },
                        new
                        {
                            Id = "https://vk.com/lellap",
                            Img = "images/Sofia_kolotilina.jpg",
                            ImgName = "images/Sofia_kolotilina",
                            Name = "Elena Popovskikh",
                            Number = 0,
                            TeenId = 2
                        },
                        new
                        {
                            Id = "https://vk.com/die_young_my_baby",
                            Img = "images/TopTelka.jpg",
                            ImgName = "images/TopTelka",
                            Name = "Anya Shelk",
                            Number = 0,
                            TeenId = 3
                        },
                        new
                        {
                            Id = "",
                            Img = "images/DaryaAfanasieva.jpg",
                            ImgName = "images/DaryaAfanasieva",
                            Name = "noname",
                            Number = 0,
                            TeenId = 4
                        });
                });
#pragma warning restore 612, 618
        }
    }
}