﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using proyectoAlkemy.Contexts;

#nullable disable

namespace proyectoAlkemy.Migrations
{
    [DbContext(typeof(DisneyContext))]
    [Migration("20220221181756_nullables")]
    partial class nullables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CharactersMovieSerie", b =>
                {
                    b.Property<int>("CharactersID")
                        .HasColumnType("int");

                    b.Property<int>("MovieSeriesID")
                        .HasColumnType("int");

                    b.HasKey("CharactersID", "MovieSeriesID");

                    b.HasIndex("MovieSeriesID");

                    b.ToTable("CharactersMovieSerie");
                });

            modelBuilder.Entity("proyectoAlkemy.Models.Characters", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lore")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("proyectoAlkemy.Models.Genres", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Asociated_Movie_Serie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.HasKey("ID");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("proyectoAlkemy.Models.MovieSerie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("GenresID")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ranking")
                        .HasColumnType("int");

                    b.Property<DateTime>("Release_Year")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("GenresID");

                    b.ToTable("MovieSeries");
                });

            modelBuilder.Entity("CharactersMovieSerie", b =>
                {
                    b.HasOne("proyectoAlkemy.Models.Characters", null)
                        .WithMany()
                        .HasForeignKey("CharactersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("proyectoAlkemy.Models.MovieSerie", null)
                        .WithMany()
                        .HasForeignKey("MovieSeriesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("proyectoAlkemy.Models.MovieSerie", b =>
                {
                    b.HasOne("proyectoAlkemy.Models.Genres", "Genres")
                        .WithMany("Movies")
                        .HasForeignKey("GenresID");

                    b.Navigation("Genres");
                });

            modelBuilder.Entity("proyectoAlkemy.Models.Genres", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
