﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BaiThiNHC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230629020844_Create_Table_NHCcau3")]
    partial class Create_Table_NHCcau3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("BaiThiNHC.Models.NHCcau3", b =>
                {
                    b.Property<string>("MaSinhVien")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenSinhVien")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaSinhVien");

                    b.ToTable("NHCcau3");
                });
#pragma warning restore 612, 618
        }
    }
}
