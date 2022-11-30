﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(LiraDb))]
    [Migration("20221130104306_newColumnsCompany")]
    partial class newColumnsCompany
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.Concrete.Companies", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyId"));

                    b.Property<float>("CompanyBalance")
                        .HasColumnType("real");

                    b.Property<float>("CompanyEBITDA")
                        .HasColumnType("real");

                    b.Property<float>("CompanyIncomeStatement")
                        .HasColumnType("real");

                    b.Property<string>("CompanyInformation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("CompanyPriceGainRate")
                        .HasColumnType("real");

                    b.Property<float>("CompanyProfit")
                        .HasColumnType("real");

                    b.Property<float>("CompanyRegularMarketChange")
                        .HasColumnType("real");

                    b.Property<float>("CompanyRegularMarketChangePercent")
                        .HasColumnType("real");

                    b.Property<float>("CompanyRegularMarketDayHigh")
                        .HasColumnType("real");

                    b.Property<float>("CompanyRegularMarketDayLow")
                        .HasColumnType("real");

                    b.Property<float>("CompanyRegularMarketPrice")
                        .HasColumnType("real");

                    b.Property<float>("CompanyRegularMarketVolume")
                        .HasColumnType("real");

                    b.Property<string>("CompanySymbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<DateTime>("CustomerCreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CustomerModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Graphs", b =>
                {
                    b.Property<int>("GraphId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GraphId"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("GraphName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GraphId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Graphs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.News", b =>
                {
                    b.Property<int>("NewsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NewsId"));

                    b.Property<DateTime>("NewsCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NewsInformation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewsName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewsTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NewsId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Share", b =>
                {
                    b.Property<int>("ShareId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShareId"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("ShareName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("SharePrice")
                        .HasColumnType("real");

                    b.Property<string>("ShareShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShareType")
                        .HasColumnType("int");

                    b.HasKey("ShareId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Shares");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Graphs", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Companies", "Company")
                        .WithMany("Graphs")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Share", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Companies", "Company")
                        .WithMany("Shares")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Companies", b =>
                {
                    b.Navigation("Graphs");

                    b.Navigation("Shares");
                });
#pragma warning restore 612, 618
        }
    }
}
