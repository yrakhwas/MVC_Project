﻿// <auto-generated />
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(EstablishentDbContext))]
    [Migration("20231031201745_createDb")]
    partial class createDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.ToTable("Credentials");
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

                    b.ToTable("Ingridients");
                });

            modelBuilder.Entity("DataAccess.Entities.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("DataAccess.Entities.PizzaIngridients", b =>
                {
                    b.Property<int>("IngridientId")
                        .HasColumnType("int");

                    b.Property<int>("PizzaId")
                        .HasColumnType("int");

                    b.HasKey("IngridientId", "PizzaId");

                    b.HasIndex("PizzaId");

                    b.ToTable("PizzaIngridients");
                });

            modelBuilder.Entity("DataAccess.Entities.Salad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Salads");
                });

            modelBuilder.Entity("DataAccess.Entities.SaladIngridients", b =>
                {
                    b.Property<int>("IngridientId")
                        .HasColumnType("int");

                    b.Property<int>("SaladId")
                        .HasColumnType("int");

                    b.HasKey("IngridientId", "SaladId");

                    b.HasIndex("SaladId");

                    b.ToTable("SaladIngridients");
                });

            modelBuilder.Entity("DataAccess.Entities.Sushi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sushis");
                });

            modelBuilder.Entity("DataAccess.Entities.SushiIngridients", b =>
                {
                    b.Property<int>("IngridientId")
                        .HasColumnType("int");

                    b.Property<int>("SushiId")
                        .HasColumnType("int");

                    b.HasKey("IngridientId", "SushiId");

                    b.HasIndex("SushiId");

                    b.ToTable("SushiIngridients");
                });

            modelBuilder.Entity("DataAccess.Entities.User", b =>
                {
                    b.Property<int>("CredentialsId")
                        .HasColumnType("int");

                    b.HasKey("CredentialsId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DataAccess.Entities.Pizza", b =>
                {
                    b.HasOne("DataAccess.Entities.User", null)
                        .WithMany("Pizza")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("DataAccess.Entities.User", null)
                        .WithMany("Salad")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("DataAccess.Entities.User", null)
                        .WithMany("Sushis")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.Navigation("Pizza");

                    b.Navigation("Salad");

                    b.Navigation("Sushis");
                });
#pragma warning restore 612, 618
        }
    }
}
