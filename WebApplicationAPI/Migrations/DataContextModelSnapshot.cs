﻿// <auto-generated />
using WebApplicationAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace WebApplicationAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ColorTshirt", b =>
                {
                    b.Property<int>("ColorsId")
                        .HasColumnType("int");

                    b.Property<int>("TshirtsId")
                        .HasColumnType("int");

                    b.HasKey("ColorsId", "TshirtsId");

                    b.HasIndex("TshirtsId");

                    b.ToTable("ColorTshirt");
                });

            modelBuilder.Entity("FabricTshirt", b =>
                {
                    b.Property<int>("FabricsId")
                        .HasColumnType("int");

                    b.Property<int>("TshirtsId")
                        .HasColumnType("int");

                    b.HasKey("FabricsId", "TshirtsId");

                    b.HasIndex("TshirtsId");

                    b.ToTable("FabricTshirt");
                });

            modelBuilder.Entity("WebApplicationAPI.Entities.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("WebApplicationAPI.Entities.Fabric", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fabrics");
                });

            modelBuilder.Entity("WebApplicationAPI.Entities.Tshirt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tshirts");
                });

            modelBuilder.Entity("WebApplicationAPI.Entities.TshirtImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<int>("FabricId")
                        .HasColumnType("int");

                    b.Property<int>("TshirtId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("FabricId");

                    b.HasIndex("TshirtId");

                    b.ToTable("TshirtImages");
                });

            modelBuilder.Entity("ColorTshirt", b =>
                {
                    b.HasOne("WebApplicationAPI.Entities.Color", null)
                        .WithMany()
                        .HasForeignKey("ColorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplicationAPI.Entities.Tshirt", null)
                        .WithMany()
                        .HasForeignKey("TshirtsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FabricTshirt", b =>
                {
                    b.HasOne("WebApplicationAPI.Entities.Fabric", null)
                        .WithMany()
                        .HasForeignKey("FabricsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplicationAPI.Entities.Tshirt", null)
                        .WithMany()
                        .HasForeignKey("TshirtsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplicationAPI.Entities.TshirtImage", b =>
                {
                    b.HasOne("WebApplicationAPI.Entities.Color", "Color")
                        .WithMany("TshirtImages")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplicationAPI.Entities.Fabric", "Fabric")
                        .WithMany("TshirtImages")
                        .HasForeignKey("FabricId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplicationAPI.Entities.Tshirt", "Tshirt")
                        .WithMany("TshirtImages")
                        .HasForeignKey("TshirtId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("Fabric");

                    b.Navigation("Tshirt");
                });

            modelBuilder.Entity("WebApplicationAPI.Entities.Color", b =>
                {
                    b.Navigation("TshirtImages");
                });

            modelBuilder.Entity("WebApplicationAPI.Entities.Fabric", b =>
                {
                    b.Navigation("TshirtImages");
                });

            modelBuilder.Entity("WebApplicationAPI.Entities.Tshirt", b =>
                {
                    b.Navigation("TshirtImages");
                });
#pragma warning restore 612, 618
        }
    }
}
