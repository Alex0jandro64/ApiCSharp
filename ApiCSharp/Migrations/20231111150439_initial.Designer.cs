﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApiCSharp.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20231111150439_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("ApiCSharp.Entidades.Acceso", b =>
                {
                    b.Property<long>("id_acceso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("id_acceso"));

                    b.Property<string>("codigo_acceso")
                        .HasColumnType("text");

                    b.Property<string>("descripcion_acceso")
                        .HasColumnType("text");

                    b.HasKey("id_acceso");

                    b.ToTable("accesos", (string)null);
                });

            modelBuilder.Entity("ApiCSharp.Entidades.Usuario", b =>
                {
                    b.Property<long>("id_usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("id_usuario"));

                    b.Property<long>("AccesoId")
                        .HasColumnType("bigint")
                        .HasColumnName("id_acceso");

                    b.Property<string>("apellidos_usuario")
                        .HasColumnType("text");

                    b.Property<string>("clave_usuario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("dni_usuario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("email_usuario")
                        .HasColumnType("text");

                    b.Property<bool?>("estaBloqueado_usuario")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("fch_alta_usuario")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("fch_baja_usuario")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("fch_fin_bloqueo_usuario")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("nombre_usuario")
                        .HasColumnType("text");

                    b.Property<string>("tlf_usuario")
                        .HasColumnType("text");

                    b.HasKey("id_usuario");

                    b.HasIndex("AccesoId");

                    b.ToTable("usuarios", (string)null);
                });

            modelBuilder.Entity("ApiCSharp.Entidades.Usuario", b =>
                {
                    b.HasOne("ApiCSharp.Entidades.Acceso", "Acceso")
                        .WithMany("Usuarios")
                        .HasForeignKey("AccesoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Acceso");
                });

            modelBuilder.Entity("ApiCSharp.Entidades.Acceso", b =>
                {
                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
