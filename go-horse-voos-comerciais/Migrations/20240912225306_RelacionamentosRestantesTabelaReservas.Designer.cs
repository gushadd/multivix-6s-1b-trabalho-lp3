﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace go_horse_voos_comerciais.Migrations
{
    [DbContext(typeof(ApiGhvcDbContext))]
    [Migration("20240912225306_RelacionamentosRestantesTabelaReservas")]
    partial class RelacionamentosRestantesTabelaReservas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("go_horse_voos_comerciais.Domain.Cliente.Clientes", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Cpf")
                        .HasColumnType("text")
                        .HasColumnName("cpf");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Endereco")
                        .HasColumnType("text")
                        .HasColumnName("endereco");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<string>("TelefoneCelular")
                        .HasColumnType("text")
                        .HasColumnName("telefoneCelular");

                    b.Property<string>("TelefoneFixo")
                        .HasColumnType("text")
                        .HasColumnName("telefoneFixo");

                    b.HasKey("Id");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("go_horse_voos_comerciais.Domain.CompanhiaOperante.CompanhiasOperantes", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Cnpj")
                        .HasColumnType("text")
                        .HasColumnName("cnpj");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("CompanhiasOperantes");
                });

            modelBuilder.Entity("go_horse_voos_comerciais.Domain.Local.Locais", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("locais");
                });

            modelBuilder.Entity("go_horse_voos_comerciais.Domain.Passagem.Passagens", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("IdReserva")
                        .HasColumnType("bigint")
                        .HasColumnName("id_reserva");

                    b.Property<int>("NumeroAssento")
                        .HasColumnType("integer")
                        .HasColumnName("numero_assento");

                    b.Property<int>("SituacaoCheckIn")
                        .HasColumnType("integer")
                        .HasColumnName("situacao_checkin");

                    b.HasKey("Id");

                    b.HasIndex("IdReserva");

                    b.ToTable("passagens");
                });

            modelBuilder.Entity("go_horse_voos_comerciais.Domain.Reserva.Reservas", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DataReserva")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_reserva");

                    b.Property<int>("FormaPagamento")
                        .HasColumnType("integer")
                        .HasColumnName("forma_pagamento");

                    b.Property<long>("IdCliente")
                        .HasColumnType("bigint")
                        .HasColumnName("id_cliente");

                    b.Property<long>("IdVoo")
                        .HasColumnType("bigint")
                        .HasColumnName("id_voo");

                    b.Property<int>("StatusReserva")
                        .HasColumnType("integer")
                        .HasColumnName("status_reserva");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdVoo");

                    b.ToTable("reservas");
                });

            modelBuilder.Entity("go_horse_voos_comerciais.Domain.Voo.Voos", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DataIda")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_ida");

                    b.Property<DateTime>("DataVolta")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("data_volta");

                    b.Property<long>("IdCompanhiaOperante")
                        .HasColumnType("bigint")
                        .HasColumnName("id_companhia_operante");

                    b.Property<long>("IdDestino")
                        .HasColumnType("bigint")
                        .HasColumnName("id_destino");

                    b.Property<long>("IdOrigem")
                        .HasColumnType("bigint")
                        .HasColumnName("id_origem");

                    b.Property<double>("Preco")
                        .HasColumnType("double precision")
                        .HasColumnName("preco");

                    b.Property<int>("QuantidadeAssentosTotal")
                        .HasColumnType("integer")
                        .HasColumnName("quantidade_assentos_total");

                    b.HasKey("Id");

                    b.HasIndex("IdDestino");

                    b.HasIndex("IdOrigem");

                    b.ToTable("voos");
                });

            modelBuilder.Entity("go_horse_voos_comerciais.Domain.Passagem.Passagens", b =>
                {
                    b.HasOne("go_horse_voos_comerciais.Domain.Reserva.Reservas", "Reserva")
                        .WithMany("Passagens")
                        .HasForeignKey("IdReserva")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("go_horse_voos_comerciais.Domain.Reserva.Reservas", b =>
                {
                    b.HasOne("go_horse_voos_comerciais.Domain.Cliente.Clientes", "Cliente")
                        .WithMany("Reservas")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("go_horse_voos_comerciais.Domain.Voo.Voos", "Voo")
                        .WithMany("Reservas")
                        .HasForeignKey("IdVoo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Voo");
                });

            modelBuilder.Entity("go_horse_voos_comerciais.Domain.Voo.Voos", b =>
                {
                    b.HasOne("go_horse_voos_comerciais.Domain.Local.Locais", "LocalDestino")
                        .WithMany("VoosDestino")
                        .HasForeignKey("IdDestino")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("go_horse_voos_comerciais.Domain.Local.Locais", "LocalOrigem")
                        .WithMany("VoosOrigem")
                        .HasForeignKey("IdOrigem")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("LocalDestino");

                    b.Navigation("LocalOrigem");
                });

            modelBuilder.Entity("go_horse_voos_comerciais.Domain.Cliente.Clientes", b =>
                {
                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("go_horse_voos_comerciais.Domain.Local.Locais", b =>
                {
                    b.Navigation("VoosDestino");

                    b.Navigation("VoosOrigem");
                });

            modelBuilder.Entity("go_horse_voos_comerciais.Domain.Reserva.Reservas", b =>
                {
                    b.Navigation("Passagens");
                });

            modelBuilder.Entity("go_horse_voos_comerciais.Domain.Voo.Voos", b =>
                {
                    b.Navigation("Reservas");
                });
#pragma warning restore 612, 618
        }
    }
}
