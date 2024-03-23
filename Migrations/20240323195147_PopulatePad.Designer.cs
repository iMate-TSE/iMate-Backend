﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using iMate.API.Data;

#nullable disable

namespace iMate.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240323195147_PopulatePad")]
    partial class PopulatePad
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("iMate.API.Data.Models.FormQuestions", b =>
                {
                    b.Property<int>("formQuestionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("formQuestionID"));

                    b.Property<string>("Question")
                        .HasColumnType("text");

                    b.Property<bool>("isHappy")
                        .HasColumnType("boolean");

                    b.Property<string[]>("multipleChoice")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.HasKey("formQuestionID");

                    b.ToTable("FormQuestions");
                });

            modelBuilder.Entity("iMate.API.Data.Models.MoodEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("moodID")
                        .HasColumnType("integer");

                    b.Property<int>("userID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("moodID");

                    b.ToTable("MoodEntry");
                });

            modelBuilder.Entity("iMate.API.Data.Models.PadRanges", b =>
                {
                    b.Property<int>("moodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("moodID"));

                    b.Property<string>("mood")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("valueArousal")
                        .HasColumnType("real");

                    b.Property<float>("valueDominance")
                        .HasColumnType("real");

                    b.Property<float>("valuePleasure")
                        .HasColumnType("real");

                    b.HasKey("moodID");

                    b.ToTable("PadRanges");

                    b.HasData(
                        new
                        {
                            moodID = 1,
                            mood = "Excited",
                            valueArousal = 1f,
                            valueDominance = 1f,
                            valuePleasure = 1f
                        },
                        new
                        {
                            moodID = 2,
                            mood = "Happy",
                            valueArousal = 0.5f,
                            valueDominance = 1f,
                            valuePleasure = 1f
                        },
                        new
                        {
                            moodID = 3,
                            mood = "Loved/ Grateful",
                            valueArousal = 0.2f,
                            valueDominance = 0.8f,
                            valuePleasure = 0.9f
                        },
                        new
                        {
                            moodID = 4,
                            mood = "Relaxed",
                            valueArousal = 0.2f,
                            valueDominance = 0.2f,
                            valuePleasure = 0.9f
                        },
                        new
                        {
                            moodID = 5,
                            mood = "Angry",
                            valueArousal = 0.9f,
                            valueDominance = 1f,
                            valuePleasure = 0.1f
                        },
                        new
                        {
                            moodID = 6,
                            mood = "Stressed",
                            valueArousal = 0.9f,
                            valueDominance = 0.7f,
                            valuePleasure = 0.2f
                        },
                        new
                        {
                            moodID = 7,
                            mood = "Anxious",
                            valueArousal = 0.6f,
                            valueDominance = 0.4f,
                            valuePleasure = 0.1f
                        },
                        new
                        {
                            moodID = 8,
                            mood = "Disgust",
                            valueArousal = 0.7f,
                            valueDominance = 0.45f,
                            valuePleasure = 0f
                        },
                        new
                        {
                            moodID = 9,
                            mood = "Sad",
                            valueArousal = 0.1f,
                            valueDominance = 0.1f,
                            valuePleasure = 0.1f
                        },
                        new
                        {
                            moodID = 10,
                            mood = "Bored",
                            valueArousal = 0.1f,
                            valueDominance = 0.3f,
                            valuePleasure = 0.2f
                        },
                        new
                        {
                            moodID = 11,
                            mood = "Sleepy",
                            valueArousal = 0.4f,
                            valueDominance = 0.4f,
                            valuePleasure = 0.4f
                        },
                        new
                        {
                            moodID = 12,
                            mood = "Lonely",
                            valueArousal = 0.3f,
                            valueDominance = 0f,
                            valuePleasure = 0.1f
                        },
                        new
                        {
                            moodID = 13,
                            mood = "Depressed",
                            valueArousal = 0f,
                            valueDominance = 0f,
                            valuePleasure = 0f
                        });
                });

            modelBuilder.Entity("iMate.API.Data.Models.Settings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("motivationalMessages")
                        .HasColumnType("boolean");

                    b.Property<bool>("practiceReminder")
                        .HasColumnType("boolean");

                    b.Property<bool>("reducedMotion")
                        .HasColumnType("boolean");

                    b.Property<string>("reminderTime")
                        .HasColumnType("text");

                    b.Property<bool>("smartScheduling")
                        .HasColumnType("boolean");

                    b.Property<bool>("soundEffects")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("iMate.API.Data.Models.SlidersQuestions", b =>
                {
                    b.Property<int>("silderQuestionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("silderQuestionID"));

                    b.Property<string>("Question")
                        .HasColumnType("text");

                    b.Property<bool>("isHappy")
                        .HasColumnType("boolean");

                    b.Property<string>("sliderOptionOne")
                        .HasColumnType("text");

                    b.Property<string>("sliderOptionTwo")
                        .HasColumnType("text");

                    b.HasKey("silderQuestionID");

                    b.ToTable("SlidersQuestions");
                });

            modelBuilder.Entity("iMate.API.Data.Models.TarotCards", b =>
                {
                    b.Property<int>("cardID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("cardID"));

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<int>("cardCreditsValue")
                        .HasColumnType("integer");

                    b.Property<int>("moodID")
                        .HasColumnType("integer");

                    b.Property<int>("targetMoodId")
                        .HasColumnType("integer");

                    b.HasKey("cardID");

                    b.HasIndex("moodID");

                    b.HasIndex("targetMoodId");

                    b.ToTable("TarotCards");
                });

            modelBuilder.Entity("iMate.API.Data.Models.User", b =>
                {
                    b.Property<int>("userID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("userID"));

                    b.Property<int>("age")
                        .HasColumnType("integer");

                    b.Property<string>("avatarPath")
                        .HasColumnType("text");

                    b.Property<int>("credits")
                        .HasColumnType("integer");

                    b.Property<string>("gender")
                        .HasColumnType("text");

                    b.Property<int>("settingsID")
                        .HasColumnType("integer");

                    b.Property<int>("streak")
                        .HasColumnType("integer");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("userID");

                    b.HasIndex("settingsID")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("iMate.API.Data.Models.MoodEntry", b =>
                {
                    b.HasOne("iMate.API.Data.Models.PadRanges", "mood")
                        .WithMany()
                        .HasForeignKey("moodID");

                    b.Navigation("mood");
                });

            modelBuilder.Entity("iMate.API.Data.Models.TarotCards", b =>
                {
                    b.HasOne("iMate.API.Data.Models.PadRanges", "mood")
                        .WithMany()
                        .HasForeignKey("moodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("iMate.API.Data.Models.PadRanges", "targetMood")
                        .WithMany()
                        .HasForeignKey("targetMoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("mood");

                    b.Navigation("targetMood");
                });

            modelBuilder.Entity("iMate.API.Data.Models.User", b =>
                {
                    b.HasOne("iMate.API.Data.Models.Settings", "Settings")
                        .WithOne("user")
                        .HasForeignKey("iMate.API.Data.Models.User", "settingsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Settings");
                });

            modelBuilder.Entity("iMate.API.Data.Models.Settings", b =>
                {
                    b.Navigation("user");
                });
#pragma warning restore 612, 618
        }
    }
}
