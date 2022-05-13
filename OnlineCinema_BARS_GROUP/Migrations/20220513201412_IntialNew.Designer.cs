﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OnlineCinema_BARS_GROUP.Data;

#nullable disable

namespace OnlineCinema_BARS_GROUP.Migrations
{
    [DbContext(typeof(CinemaContext))]
    [Migration("20220513201412_IntialNew")]
    partial class IntialNew
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.Property<Guid>("GenresId")
                        .HasColumnType("uuid");

                    b.Property<int>("MoviesId")
                        .HasColumnType("integer");

                    b.HasKey("GenresId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("GenreMovie");
                });

            modelBuilder.Entity("MoviePlaylist", b =>
                {
                    b.Property<int>("MoviesId")
                        .HasColumnType("integer");

                    b.Property<Guid>("PlaylistsId")
                        .HasColumnType("uuid");

                    b.HasKey("MoviesId", "PlaylistsId");

                    b.HasIndex("PlaylistsId");

                    b.ToTable("MoviePlaylist");
                });

            modelBuilder.Entity("MovieRoom", b =>
                {
                    b.Property<int>("MoviesId")
                        .HasColumnType("integer");

                    b.Property<Guid>("RoomsId")
                        .HasColumnType("uuid");

                    b.HasKey("MoviesId", "RoomsId");

                    b.HasIndex("RoomsId");

                    b.ToTable("MovieRoom");
                });

            modelBuilder.Entity("OnlineCinema_BARS_GROUP.Data.Models.AgeRestriction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AgeRestrictions");
                });

            modelBuilder.Entity("OnlineCinema_BARS_GROUP.Data.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("OnlineCinema_BARS_GROUP.Data.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<int>("Dislikes")
                        .HasColumnType("integer");

                    b.Property<int>("Likes")
                        .HasColumnType("integer");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uuid");

                    b.Property<int?>("ParentId1")
                        .HasColumnType("integer");

                    b.Property<Guid>("ReviewId")
                        .HasColumnType("uuid");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ParentId1");

                    b.HasIndex("ReviewId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("OnlineCinema_BARS_GROUP.Data.Models.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("RoomId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("OnlineCinema_BARS_GROUP.Data.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<Guid?>("AgeRestrictionId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<TimeSpan?>("Duration")
                        .HasColumnType("interval");

                    b.Property<string>("FilmPath")
                        .HasColumnType("text");

                    b.Property<string>("ImagePath")
                        .HasColumnType("text");

                    b.Property<string>("LongDescription")
                        .HasColumnType("text");

                    b.Property<double>("Rating")
                        .HasColumnType("double precision");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("Views")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AgeRestrictionId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("OnlineCinema_BARS_GROUP.Data.Models.Playlist", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Playlists");
                });

            modelBuilder.Entity("OnlineCinema_BARS_GROUP.Data.Models.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Dislikes")
                        .HasColumnType("integer");

                    b.Property<int>("Likes")
                        .HasColumnType("integer");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer");

                    b.Property<long>("Time")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("MovieId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("OnlineCinema_BARS_GROUP.Data.Models.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("OnlineCinema_BARS_GROUP.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RoomUser", b =>
                {
                    b.Property<Guid>("RoomsId")
                        .HasColumnType("uuid");

                    b.Property<int>("UsersId")
                        .HasColumnType("integer");

                    b.HasKey("RoomsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("RoomUser");
                });

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.HasOne("OnlineCinema_BARS_GROUP.Data.Models.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineCinema_BARS_GROUP.Data.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MoviePlaylist", b =>
                {
                    b.HasOne("OnlineCinema_BARS_GROUP.Data.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineCinema_BARS_GROUP.Data.Models.Playlist", null)
                        .WithMany()
                        .HasForeignKey("PlaylistsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieRoom", b =>
                {
                    b.HasOne("OnlineCinema_BARS_GROUP.Data.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineCinema_BARS_GROUP.Data.Models.Room", null)
                        .WithMany()
                        .HasForeignKey("RoomsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineCinema_BARS_GROUP.Data.Models.Comment", b =>
                {
                    b.HasOne("OnlineCinema_BARS_GROUP.Data.Models.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineCinema_BARS_GROUP.Data.Models.Comment", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId1");

                    b.HasOne("OnlineCinema_BARS_GROUP.Data.Models.Review", "Review")
                        .WithMany()
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Parent");

                    b.Navigation("Review");
                });

            modelBuilder.Entity("OnlineCinema_BARS_GROUP.Data.Models.Genre", b =>
                {
                    b.HasOne("OnlineCinema_BARS_GROUP.Data.Models.Room", null)
                        .WithMany("Genres")
                        .HasForeignKey("RoomId");
                });

            modelBuilder.Entity("OnlineCinema_BARS_GROUP.Data.Models.Movie", b =>
                {
                    b.HasOne("OnlineCinema_BARS_GROUP.Data.Models.AgeRestriction", "AgeRestriction")
                        .WithMany("Movies")
                        .HasForeignKey("AgeRestrictionId");

                    b.HasOne("OnlineCinema_BARS_GROUP.Data.Models.Category", "Category")
                        .WithMany("Movies")
                        .HasForeignKey("CategoryId");

                    b.HasOne("OnlineCinema_BARS_GROUP.Data.Models.User", null)
                        .WithMany("Movies")
                        .HasForeignKey("UserId");

                    b.Navigation("AgeRestriction");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("OnlineCinema_BARS_GROUP.Data.Models.Playlist", b =>
                {
                    b.HasOne("OnlineCinema_BARS_GROUP.Data.Models.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("OnlineCinema_BARS_GROUP.Data.Models.Review", b =>
                {
                    b.HasOne("OnlineCinema_BARS_GROUP.Data.Models.User", "Author")
                        .WithMany("Reviews")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineCinema_BARS_GROUP.Data.Models.Movie", "Movie")
                        .WithMany("Reviews")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("RoomUser", b =>
                {
                    b.HasOne("OnlineCinema_BARS_GROUP.Data.Models.Room", null)
                        .WithMany()
                        .HasForeignKey("RoomsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineCinema_BARS_GROUP.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineCinema_BARS_GROUP.Data.Models.AgeRestriction", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("OnlineCinema_BARS_GROUP.Data.Models.Category", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("OnlineCinema_BARS_GROUP.Data.Models.Comment", b =>
                {
                    b.Navigation("Children");
                });

            modelBuilder.Entity("OnlineCinema_BARS_GROUP.Data.Models.Movie", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("OnlineCinema_BARS_GROUP.Data.Models.Room", b =>
                {
                    b.Navigation("Genres");
                });

            modelBuilder.Entity("OnlineCinema_BARS_GROUP.Data.Models.User", b =>
                {
                    b.Navigation("Movies");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
