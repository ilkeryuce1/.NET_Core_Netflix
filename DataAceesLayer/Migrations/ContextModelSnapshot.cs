﻿// <auto-generated />
using System;
using DataAceesLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAceesLayer.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.Concrete.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"));

                    b.Property<int>("AccountKindId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PacketId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountId");

                    b.HasIndex("AccountKindId");

                    b.HasIndex("PacketId");

                    b.ToTable("Tbl_Accounts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.AccountKind", b =>
                {
                    b.Property<int>("AccounKindtId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccounKindtId"));

                    b.Property<int>("AccounName")
                        .HasColumnType("int");

                    b.HasKey("AccounKindtId");

                    b.ToTable("Tbl_AccountKinds");
                });

            modelBuilder.Entity("EntityLayer.Concrete.CommentRated", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("CommentDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("Rated")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("AccountId");

                    b.HasIndex("MovieId");

                    b.ToTable("Tbl_CommentRateds");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"));

                    b.Property<string>("CoverPhotoLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Episodes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieKindId")
                        .HasColumnType("int");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MovieYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("TrailerLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.HasIndex("MovieKindId");

                    b.ToTable("Tbl_Movies");
                });

            modelBuilder.Entity("EntityLayer.Concrete.MovieKind", b =>
                {
                    b.Property<int>("MovieKindId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieKindId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieKindName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieKindId");

                    b.ToTable("Tbl_MovieKinds");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Packet", b =>
                {
                    b.Property<int>("PacketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PacketId"));

                    b.Property<int>("AccountOdUserCount")
                        .HasColumnType("int");

                    b.Property<string>("PacketName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("PacketId");

                    b.ToTable("Tbl_Packets");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Account", b =>
                {
                    b.HasOne("EntityLayer.Concrete.AccountKind", "AccountKind")
                        .WithMany()
                        .HasForeignKey("AccountKindId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Packet", "Packet")
                        .WithMany()
                        .HasForeignKey("PacketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountKind");

                    b.Navigation("Packet");
                });

            modelBuilder.Entity("EntityLayer.Concrete.CommentRated", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Movie", "Movie")
                        .WithMany("CommentRated")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Movie", b =>
                {
                    b.HasOne("EntityLayer.Concrete.MovieKind", "MovieKind")
                        .WithMany("Movie")
                        .HasForeignKey("MovieKindId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MovieKind");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Movie", b =>
                {
                    b.Navigation("CommentRated");
                });

            modelBuilder.Entity("EntityLayer.Concrete.MovieKind", b =>
                {
                    b.Navigation("Movie");
                });
#pragma warning restore 612, 618
        }
    }
}
