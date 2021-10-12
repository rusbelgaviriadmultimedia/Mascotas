﻿// <auto-generated />
using System;
using Mascotas.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mascotas.App.Persistencia.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211011221458_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Mascotas.App.Dominio.Entidades.ClaseEmpresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazonSocial")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("Mascotas.App.Dominio.Entidades.ClaseEstadoMascota", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("EstadoDeAnimo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrecuenciaCardiaca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrecuenciaRespiratoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Peso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Temperatura")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("estadoMascota");
                });

            modelBuilder.Entity("Mascotas.App.Dominio.Entidades.ClaseListaMascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("IdDueno")
                        .HasColumnType("int");

                    b.Property<int>("IdMascotas")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("listaMascota");
                });

            modelBuilder.Entity("Mascotas.App.Dominio.Entidades.ClaseListaMedicos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("IdMedicos")
                        .HasColumnType("int");

                    b.Property<string>("IdentificacionMedico")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("listaMedicos");
                });

            modelBuilder.Entity("Mascotas.App.Dominio.Entidades.ClaseListaVisitas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("IdDueno")
                        .HasColumnType("int");

                    b.Property<int>("IdVisitas")
                        .HasColumnType("int");

                    b.Property<int>("IdentificacionMedico")
                        .HasColumnType("int");

                    b.Property<int>("NombreMascota")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ListaVisitas");
                });

            modelBuilder.Entity("Mascotas.App.Dominio.Entidades.ClaseMascota", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("ColorDeOjos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColorDePiel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Estatura")
                        .HasColumnType("real");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Raza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tipoAnimal")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Mascota");
                });

            modelBuilder.Entity("Mascotas.App.Dominio.Entidades.ClasePersona", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persona");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ClasePersona");
                });

            modelBuilder.Entity("Mascotas.App.Dominio.Entidades.ClaseSolicitudDeVisita", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("IdentificacionDuenoMascota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ListaMedicosId")
                        .HasColumnType("int");

                    b.Property<int>("TipoAnimal")
                        .HasColumnType("int");

                    b.Property<int?>("listaMascotaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ListaMedicosId");

                    b.HasIndex("listaMascotaId");

                    b.ToTable("SolicitudDeVisita");
                });

            modelBuilder.Entity("Mascotas.App.Dominio.Entidades.ClaseVisitaVeterinaria", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("EstadoMascotaId")
                        .HasColumnType("bigint");

                    b.Property<string>("FechaVisita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdVeterinario")
                        .HasColumnType("int");

                    b.Property<string>("Recomendaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("medicamentos")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EstadoMascotaId");

                    b.ToTable("VisitaVeterinaria");
                });

            modelBuilder.Entity("Mascotas.App.Dominio.Entidades.ClaseDatosDuenos", b =>
                {
                    b.HasBaseType("Mascotas.App.Dominio.Entidades.ClasePersona");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ListaMascotasId")
                        .HasColumnType("int");

                    b.HasIndex("ListaMascotasId");

                    b.HasDiscriminator().HasValue("ClaseDatosDuenos");
                });

            modelBuilder.Entity("Mascotas.App.Dominio.Entidades.ClaseMedicoVeterinario", b =>
                {
                    b.HasBaseType("Mascotas.App.Dominio.Entidades.ClasePersona");

                    b.Property<string>("TarjetaProfesional")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoAnimal")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("ClaseMedicoVeterinario");
                });

            modelBuilder.Entity("Mascotas.App.Dominio.Entidades.ClaseSolicitudDeVisita", b =>
                {
                    b.HasOne("Mascotas.App.Dominio.Entidades.ClaseListaMedicos", "ListaMedicos")
                        .WithMany()
                        .HasForeignKey("ListaMedicosId");

                    b.HasOne("Mascotas.App.Dominio.Entidades.ClaseListaMascota", "listaMascota")
                        .WithMany()
                        .HasForeignKey("listaMascotaId");

                    b.Navigation("listaMascota");

                    b.Navigation("ListaMedicos");
                });

            modelBuilder.Entity("Mascotas.App.Dominio.Entidades.ClaseVisitaVeterinaria", b =>
                {
                    b.HasOne("Mascotas.App.Dominio.Entidades.ClaseEstadoMascota", "EstadoMascota")
                        .WithMany()
                        .HasForeignKey("EstadoMascotaId");

                    b.Navigation("EstadoMascota");
                });

            modelBuilder.Entity("Mascotas.App.Dominio.Entidades.ClaseDatosDuenos", b =>
                {
                    b.HasOne("Mascotas.App.Dominio.Entidades.ClaseListaMascota", "ListaMascotas")
                        .WithMany()
                        .HasForeignKey("ListaMascotasId");

                    b.Navigation("ListaMascotas");
                });
#pragma warning restore 612, 618
        }
    }
}
