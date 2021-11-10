﻿// <auto-generated />
using Demo_Angular_Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Demo_Angular_Core.Migrations
{
    [DbContext(typeof(FootballDbContext))]
    [Migration("20211109170627_initdb")]
    partial class initdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Demo_Angular_Core.Model.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Appearances")
                        .HasColumnType("int");

                    b.Property<int>("Goals")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<int>("ShirtNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Appearances = 500,
                            Goals = 54,
                            Name = "C. Ronaldo",
                            Position = 3,
                            ShirtNo = 7
                        },
                        new
                        {
                            Id = 2,
                            Appearances = 285,
                            Goals = 28,
                            Name = "Paul Pogba",
                            Position = 2,
                            ShirtNo = 6
                        },
                        new
                        {
                            Id = 3,
                            Appearances = 335,
                            Goals = 33,
                            Name = "David de Gea",
                            Position = 0,
                            ShirtNo = 2
                        },
                        new
                        {
                            Id = 4,
                            Appearances = 200,
                            Goals = 25,
                            Name = "Phil Jones",
                            Position = 1,
                            ShirtNo = 5
                        },
                        new
                        {
                            Id = 5,
                            Appearances = 430,
                            Goals = 50,
                            Name = "Lionel Messi",
                            Position = 4,
                            ShirtNo = 8
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
