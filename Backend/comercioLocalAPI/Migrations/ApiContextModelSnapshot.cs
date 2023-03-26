﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using comercioLocalAPI;

#nullable disable

namespace comercioLocalAPI.Migrations
{
    [DbContext(typeof(ApiContext))]
    partial class ApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("comercioLocalAPI.Model.Cliente", b =>
                {
                    b.Property<Guid>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("cnpj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("endereço")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomeEmpresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomeResponsavel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("comercioLocalAPI.Model.Fornecedor", b =>
                {
                    b.Property<Guid>("FornecedorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("cnpj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("contadorVendas")
                        .HasColumnType("int");

                    b.Property<string>("cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("endereço")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomeEmpresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomeResponsavel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FornecedorId");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("comercioLocalAPI.Model.Negociacao", b =>
                {
                    b.Property<Guid>("NegociacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FornecedorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime2");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("NegociacaoId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Negociacoe");
                });

            modelBuilder.Entity("comercioLocalAPI.Model.Produto", b =>
                {
                    b.Property<Guid>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FornecedorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("NegociacaoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("descricaoProduto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomeProduto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("quantidadeProduto")
                        .HasColumnType("int");

                    b.Property<double>("valorProuto")
                        .HasColumnType("float");

                    b.HasKey("ProdutoId");

                    b.HasIndex("FornecedorId");

                    b.HasIndex("NegociacaoId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("comercioLocalAPI.Model.Negociacao", b =>
                {
                    b.HasOne("comercioLocalAPI.Model.Cliente", null)
                        .WithMany("negociacoes")
                        .HasForeignKey("ClienteId");

                    b.HasOne("comercioLocalAPI.Model.Fornecedor", null)
                        .WithMany("negociacoes")
                        .HasForeignKey("FornecedorId");
                });

            modelBuilder.Entity("comercioLocalAPI.Model.Produto", b =>
                {
                    b.HasOne("comercioLocalAPI.Model.Fornecedor", null)
                        .WithMany("produtos")
                        .HasForeignKey("FornecedorId");

                    b.HasOne("comercioLocalAPI.Model.Negociacao", null)
                        .WithMany("produtos")
                        .HasForeignKey("NegociacaoId");
                });

            modelBuilder.Entity("comercioLocalAPI.Model.Cliente", b =>
                {
                    b.Navigation("negociacoes");
                });

            modelBuilder.Entity("comercioLocalAPI.Model.Fornecedor", b =>
                {
                    b.Navigation("negociacoes");

                    b.Navigation("produtos");
                });

            modelBuilder.Entity("comercioLocalAPI.Model.Negociacao", b =>
                {
                    b.Navigation("produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
