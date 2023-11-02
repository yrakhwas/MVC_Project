﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(EstablishentDbContext))]
    partial class EstablishentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Entities.Credentials", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Credentials", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.Ingridient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Ingridients", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Pizzas", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.PizzaIngridients", b =>
                {
                    b.Property<int>("PizzaId")
                        .HasColumnType("int");

                    b.Property<int>("IngridientId")
                        .HasColumnType("int");

                    b.HasKey("PizzaId", "IngridientId");

                    b.HasIndex("IngridientId");

                    b.ToTable("PizzaIngridients", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.Salad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Salads", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.SaladIngridients", b =>
                {
                    b.Property<int>("SaladId")
                        .HasColumnType("int");

                    b.Property<int>("IngridientId")
                        .HasColumnType("int");

                    b.HasKey("SaladId", "IngridientId");

                    b.HasIndex("IngridientId");

                    b.ToTable("SaladIngridients", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.Sushi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Sushis", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.SushiIngridients", b =>
                {
                    b.Property<int>("SushiId")
                        .HasColumnType("int");

                    b.Property<int>("IngridientId")
                        .HasColumnType("int");

                    b.HasKey("SushiId", "IngridientId");

                    b.HasIndex("IngridientId");

                    b.ToTable("SushiIngridients", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.User", b =>
                {
                    b.Property<int>("CredentialsId")
                        .HasColumnType("int");

                    b.HasKey("CredentialsId");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("DataAccess.Entities.Pizza", b =>
                {
                    b.HasOne("DataAccess.Entities.User", "User")
                        .WithMany("Pizzas")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataAccess.Entities.PizzaIngridients", b =>
                {
                    b.HasOne("DataAccess.Entities.Ingridient", "Ingridient")
                        .WithMany()
                        .HasForeignKey("IngridientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.Pizza", "Pizza")
                        .WithMany()
                        .HasForeignKey("PizzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingridient");

                    b.Navigation("Pizza");
                });

            modelBuilder.Entity("DataAccess.Entities.Salad", b =>
                {
                    b.HasOne("DataAccess.Entities.User", "User")
                        .WithMany("Salad")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataAccess.Entities.SaladIngridients", b =>
                {
                    b.HasOne("DataAccess.Entities.Ingridient", "Ingridient")
                        .WithMany()
                        .HasForeignKey("IngridientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.Salad", "Salad")
                        .WithMany()
                        .HasForeignKey("SaladId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingridient");

                    b.Navigation("Salad");
                });

            modelBuilder.Entity("DataAccess.Entities.Sushi", b =>
                {
                    b.HasOne("DataAccess.Entities.User", "User")
                        .WithMany("Sushis")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataAccess.Entities.SushiIngridients", b =>
                {
                    b.HasOne("DataAccess.Entities.Ingridient", "Ingridient")
                        .WithMany()
                        .HasForeignKey("IngridientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.Sushi", "Sushi")
                        .WithMany()
                        .HasForeignKey("SushiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingridient");

                    b.Navigation("Sushi");
                });

            modelBuilder.Entity("DataAccess.Entities.User", b =>
                {
                    b.HasOne("DataAccess.Entities.Credentials", "Credentials")
                        .WithOne("User")
                        .HasForeignKey("DataAccess.Entities.User", "CredentialsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Credentials");
                });

            modelBuilder.Entity("DataAccess.Entities.Credentials", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("DataAccess.Entities.User", b =>
                {
                    b.Navigation("Pizzas");

                    b.Navigation("Salad");

                    b.Navigation("Sushis");
                });
#pragma warning restore 612, 618
        }
    }
}
