﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eEnchere.Data;

namespace eEnchere.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211121181238_mariemmigration")]
    partial class mariemmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eEnchere.Data.Client_Room", b =>
                {
                    b.Property<int>("IdClient")
                        .HasColumnType("int");

                    b.Property<int>("IdRoom")
                        .HasColumnType("int");

                    b.HasKey("IdClient", "IdRoom");

                    b.HasIndex("IdRoom");

                    b.ToTable("Client_Rooms");
                });

            modelBuilder.Entity("eEnchere.Models.Admin", b =>
                {
                    b.Property<int>("IdAdmin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotDePasse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomAdmin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrénomAdmin")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAdmin");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("eEnchere.Models.Article", b =>
                {
                    b.Property<int>("IdArticle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Etat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Prix")
                        .HasColumnType("int");

                    b.HasKey("IdArticle");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("eEnchere.Models.Client", b =>
                {
                    b.Property<int>("IdClient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MailClient")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotDePasse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomClient")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrénomClient")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pseudo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Solde")
                        .HasColumnType("float");

                    b.HasKey("IdClient");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("eEnchere.Models.Room", b =>
                {
                    b.Property<int>("IdRoom")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateDebut")
                        .HasColumnType("datetime2");

                    b.Property<float>("DernierMise")
                        .HasColumnType("real");

                    b.Property<float>("FraisRoom")
                        .HasColumnType("real");

                    b.Property<int>("IdArticle")
                        .HasColumnType("int");

                    b.Property<float>("MontantEnchére")
                        .HasColumnType("real");

                    b.Property<float>("MontantEnchéreFinal")
                        .HasColumnType("real");

                    b.Property<float>("MontantInitial")
                        .HasColumnType("real");

                    b.Property<float>("MontantLancement")
                        .HasColumnType("real");

                    b.Property<string>("NomRoom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NombreParticipants")
                        .HasColumnType("int");

                    b.Property<int>("Timeur")
                        .HasColumnType("int");

                    b.HasKey("IdRoom");

                    b.HasIndex("IdArticle");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("eEnchere.Data.Client_Room", b =>
                {
                    b.HasOne("eEnchere.Models.Client", "Client")
                        .WithMany("Clients_Rooms")
                        .HasForeignKey("IdClient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eEnchere.Models.Room", "Room")
                        .WithMany("Clients_Rooms")
                        .HasForeignKey("IdRoom")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("eEnchere.Models.Room", b =>
                {
                    b.HasOne("eEnchere.Models.Article", "Article")
                        .WithMany()
                        .HasForeignKey("IdArticle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");
                });

            modelBuilder.Entity("eEnchere.Models.Client", b =>
                {
                    b.Navigation("Clients_Rooms");
                });

            modelBuilder.Entity("eEnchere.Models.Room", b =>
                {
                    b.Navigation("Clients_Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
