﻿// <auto-generated />
using System;
using Franlly_P2_APLI2.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Franlly_P2_APLI2.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("Franlly_P2_APLI2.Models.Clientes", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            ClienteId = 1,
                            Nombres = "FERRETERIA GAMA"
                        },
                        new
                        {
                            ClienteId = 2,
                            Nombres = "AVALON DISCO"
                        },
                        new
                        {
                            ClienteId = 3,
                            Nombres = "PRESTAMOS CEFIPROD"
                        });
                });

            modelBuilder.Entity("Franlly_P2_APLI2.Models.Cobros", b =>
                {
                    b.Property<int>("CobroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Observaciones")
                        .HasColumnType("TEXT");

                    b.Property<double>("TotalCobro")
                        .HasColumnType("REAL");

                    b.Property<decimal>("Totales")
                        .HasColumnType("TEXT");

                    b.HasKey("CobroId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Cobros");
                });

            modelBuilder.Entity("Franlly_P2_APLI2.Models.CobrosDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Cobrado")
                        .HasColumnType("REAL");

                    b.Property<int>("CobroId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VentaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CobroId");

                    b.HasIndex("VentaId");

                    b.ToTable("CobrosDetalle");
                });

            modelBuilder.Entity("Franlly_P2_APLI2.Models.Ventas", b =>
                {
                    b.Property<int>("VentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Balance")
                        .HasColumnType("REAL");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.HasKey("VentaId");

                    b.ToTable("Ventas");

                    b.HasData(
                        new
                        {
                            VentaId = 1,
                            Balance = 1000.0,
                            ClienteId = 1,
                            Fecha = new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Monto = 1000.0
                        },
                        new
                        {
                            VentaId = 2,
                            Balance = 800.0,
                            ClienteId = 1,
                            Fecha = new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Monto = 900.0
                        },
                        new
                        {
                            VentaId = 3,
                            Balance = 2000.0,
                            ClienteId = 2,
                            Fecha = new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Monto = 2000.0
                        },
                        new
                        {
                            VentaId = 4,
                            Balance = 1800.0,
                            ClienteId = 2,
                            Fecha = new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Monto = 1900.0
                        },
                        new
                        {
                            VentaId = 5,
                            Balance = 3000.0,
                            ClienteId = 3,
                            Fecha = new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Monto = 3000.0
                        },
                        new
                        {
                            VentaId = 6,
                            Balance = 1900.0,
                            ClienteId = 3,
                            Fecha = new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Monto = 2900.0
                        });
                });

            modelBuilder.Entity("Franlly_P2_APLI2.Models.Cobros", b =>
                {
                    b.HasOne("Franlly_P2_APLI2.Models.Clientes", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Franlly_P2_APLI2.Models.CobrosDetalle", b =>
                {
                    b.HasOne("Franlly_P2_APLI2.Models.Cobros", "Cobro")
                        .WithMany("Detalle")
                        .HasForeignKey("CobroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Franlly_P2_APLI2.Models.Ventas", "Venta")
                        .WithMany()
                        .HasForeignKey("VentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cobro");

                    b.Navigation("Venta");
                });

            modelBuilder.Entity("Franlly_P2_APLI2.Models.Cobros", b =>
                {
                    b.Navigation("Detalle");
                });
#pragma warning restore 612, 618
        }
    }
}
