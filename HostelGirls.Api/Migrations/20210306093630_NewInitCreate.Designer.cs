﻿// <auto-generated />
using HostelGirls.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HostelGirls.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210306093630_NewInitCreate")]
    partial class NewInitCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GirlsRanking.Girls.Teen", b =>
                {
                    b.Property<int>("TeenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("TeenId");

                    b.ToTable("Teens");

                    b.HasData(
                        new
                        {
                            TeenId = 1,
                            Id = "https://vk.com/id412379471",
                            Img = "images/Amaliya.jpg",
                            ImgName = "images/Amaliya",
                            Name = "Aurora Redfield",
                            Number = 0
                        },
                        new
                        {
                            TeenId = 2,
                            Id = "https://vk.com/lellap",
                            Img = "images/Sofia_kolotilina.jpg",
                            ImgName = "images/Sofia_kolotilina",
                            Name = "Elena Popovskikh",
                            Number = 0
                        },
                        new
                        {
                            TeenId = 3,
                            Id = "https://vk.com/die_young_my_baby",
                            Img = "images/TopTelka.jpg",
                            ImgName = "images/TopTelka",
                            Name = "Anya Shelk",
                            Number = 0
                        },
                        new
                        {
                            TeenId = 4,
                            Id = "",
                            Img = "images/DaryaAfanasieva.jpg",
                            ImgName = "images/DaryaAfanasieva",
                            Name = "noname",
                            Number = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
