// <auto-generated />
using System;
using DeveloperDemoPortal.Server.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DeveloperDemoPortal.Server.Migrations
{
    [DbContext(typeof(DeveloperDbContext))]
    [Migration("20221001120016_CreatedDeveloperTable")]
    partial class CreatedDeveloperTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DeveloperDemoPortal.Shared.Models.Developer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Developers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b8a1d4a4-f55c-42e4-b4ae-d09ef72f968f"),
                            Company = "Microsoft",
                            Email = "codefather@code.com",
                            UserName = "CodeFather"
                        },
                        new
                        {
                            Id = new Guid("107d0302-033a-49b8-9546-604236dd3c55"),
                            Company = "CodeUnparalled",
                            Email = "chiefscientist@code.com",
                            UserName = "ChiefScientist"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
