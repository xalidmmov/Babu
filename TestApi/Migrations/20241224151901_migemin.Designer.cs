﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestApi.DAL;

#nullable disable

namespace TestApi.Migrations
{
    [DbContext(typeof(BabuDbContext))]
    [Migration("20241224151901_migemin")]
    partial class migemin
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TestApi.Entities.BannedWord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WordId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WordId");

                    b.ToTable("BannedWords");
                });

            modelBuilder.Entity("TestApi.Entities.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BannedWordCount")
                        .HasColumnType("int");

                    b.Property<int>("FailCount")
                        .HasColumnType("int");

                    b.Property<string>("LangCode")
                        .IsRequired()
                        .HasColumnType("nchar(2)");

                    b.Property<int?>("Score")
                        .HasColumnType("int");

                    b.Property<int>("SkipCount")
                        .HasColumnType("int");

                    b.Property<int?>("SuccessAnswer")
                        .HasColumnType("int");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.Property<int?>("WrongAnswer")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LangCode");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("TestApi.Entities.Language", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(2)
                        .HasColumnType("nchar(2)")
                        .IsFixedLength();

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("Code");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Code = "az",
                            Icon = "https://cdn-icons-png.flaticon.com/512/330/330544.png",
                            Name = "Azərbaycan"
                        });
                });

            modelBuilder.Entity("TestApi.Entities.Word", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("LangCode")
                        .IsRequired()
                        .HasColumnType("nchar(2)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("Id");

                    b.HasIndex("LangCode");

                    b.ToTable("Words");
                });

            modelBuilder.Entity("TestApi.Entities.BannedWord", b =>
                {
                    b.HasOne("TestApi.Entities.Word", "Word")
                        .WithMany("BannedWords")
                        .HasForeignKey("WordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Word");
                });

            modelBuilder.Entity("TestApi.Entities.Game", b =>
                {
                    b.HasOne("TestApi.Entities.Language", "Language")
                        .WithMany("Games")
                        .HasForeignKey("LangCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");
                });

            modelBuilder.Entity("TestApi.Entities.Word", b =>
                {
                    b.HasOne("TestApi.Entities.Language", "Language")
                        .WithMany("Words")
                        .HasForeignKey("LangCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");
                });

            modelBuilder.Entity("TestApi.Entities.Language", b =>
                {
                    b.Navigation("Games");

                    b.Navigation("Words");
                });

            modelBuilder.Entity("TestApi.Entities.Word", b =>
                {
                    b.Navigation("BannedWords");
                });
#pragma warning restore 612, 618
        }
    }
}