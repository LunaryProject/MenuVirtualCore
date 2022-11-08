﻿// <auto-generated />
using System;
using MenuLunary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MenuLunary.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MenuLunary.Models.Campanhas", b =>
                {
                    b.Property<int>("CAMID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CAMID"), 1L, 1);

                    b.Property<string>("CAMDESCRICAO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Descrição");

                    b.Property<byte[]>("CAMFOTO")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("Foto");

                    b.Property<double>("CAMPRECO")
                        .HasColumnType("float")
                        .HasColumnName("Preço");

                    b.HasKey("CAMID");

                    b.ToTable("Campanhas");
                });

            modelBuilder.Entity("MenuLunary.Models.Categorias", b =>
                {
                    b.Property<string>("RESTACATEGORIA")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Categoria");

                    b.HasKey("RESTACATEGORIA");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("MenuLunary.Models.Estabelicimento", b =>
                {
                    b.Property<int>("ESTABID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ESTABID"), 1L, 1);

                    b.Property<string>("ESTABBAIRRO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Bairro");

                    b.Property<string>("ESTABCEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CEP");

                    b.Property<string>("ESTABENDERECO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Endereço");

                    b.Property<string>("ESTABLOGIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Login");

                    b.Property<string>("ESTABNOME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome");

                    b.Property<string>("ESTABSENHA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Senha");

                    b.Property<string>("ESTATELEFONE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Telefone");

                    b.Property<string>("ESTATIPO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Tipo");

                    b.HasKey("ESTABID");

                    b.ToTable("Estabelicimento");
                });

            modelBuilder.Entity("MenuLunary.Models.Restaurante", b =>
                {
                    b.Property<int>("RESTAUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RESTAUID"), 1L, 1);

                    b.Property<int>("Curtidas")
                        .HasColumnType("int")
                        .HasColumnName("Curtidas");

                    b.Property<bool>("Disponibilidade")
                        .HasColumnType("bit")
                        .HasColumnName("Disponibilidade");

                    b.Property<bool>("Oferta")
                        .HasColumnType("bit")
                        .HasColumnName("Oferta");

                    b.Property<string>("RESTACATEGORIA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Categoria");

                    b.Property<string>("RESTADESCRICAO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Descrição");

                    b.Property<string>("RESTANOME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome");

                    b.Property<double>("RESTAPRECO")
                        .HasColumnType("float")
                        .HasColumnName("Preço");

                    b.Property<double>("RESTAPREPROMOCAO")
                        .HasColumnType("float")
                        .HasColumnName("Promoção");

                    b.Property<byte[]>("imagem")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("imagem");

                    b.HasKey("RESTAUID");

                    b.ToTable("Restaurante");
                });
#pragma warning restore 612, 618
        }
    }
}