﻿// <auto-generated />
using System;
using DAL.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DAL.Migrations
{
    [DbContext(typeof(WebApiContext))]
    partial class AdminContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("DAL.Domain.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<string>("Body")
                        .HasColumnType("text");

                    b.Property<string>("Header")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("DAL.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int[]>("Role")
                        .HasColumnType("integer[]");

                    b.Property<bool>("State")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DAL.Domain.Сomment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<int>("InvestmentLevel")
                        .HasColumnType("integer");

                    b.Property<int?>("NewsId")
                        .HasColumnType("integer");

                    b.Property<int>("Root")
                        .HasColumnType("integer");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.Property<int?>("СommentId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("NewsId");

                    b.HasIndex("СommentId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("DAL.Domain.News", b =>
                {
                    b.HasOne("DAL.Domain.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("DAL.Domain.Сomment", b =>
                {
                    b.HasOne("DAL.Domain.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("DAL.Domain.News", "News")
                        .WithMany("Сomments")
                        .HasForeignKey("NewsId");

                    b.HasOne("DAL.Domain.Сomment", null)
                        .WithMany("Comments")
                        .HasForeignKey("СommentId");

                    b.Navigation("Author");

                    b.Navigation("News");
                });

            modelBuilder.Entity("DAL.Domain.News", b =>
                {
                    b.Navigation("Сomments");
                });

            modelBuilder.Entity("DAL.Domain.Сomment", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
