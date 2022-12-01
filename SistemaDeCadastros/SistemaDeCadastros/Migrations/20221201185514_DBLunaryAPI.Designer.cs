﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaDeCadastros.Data;

#nullable disable

namespace SistemaDeCadastros.Migrations
{
    [DbContext(typeof(DbSistemas))]
    [Migration("20221201185514_DBLunaryAPI")]
    partial class DBLunaryAPI
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SistemaDeCadastros.Models.PratosModel", b =>
                {
                    b.Property<int>("RESTAUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RESTAUID"), 1L, 1);

                    b.Property<string>("RESTACATEGORIA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RESTADESCRICAO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RESTANOME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("RESTAPRECO")
                        .HasColumnType("float");

                    b.Property<double>("RESTAPREPROMOCAO")
                        .HasColumnType("float");

                    b.HasKey("RESTAUID");

                    b.ToTable("Pratos");
                });
#pragma warning restore 612, 618
        }
    }
}