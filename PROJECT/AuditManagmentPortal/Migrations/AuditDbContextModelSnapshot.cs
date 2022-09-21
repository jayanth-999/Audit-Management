﻿// <auto-generated />
using AuditManagmentPortal.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AuditManagmentPortal.Migrations
{
    [DbContext(typeof(AuditDbContext))]
    partial class AuditDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AuditManagmentPortal.Models.StoreAuditResponce", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationOwnerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuditDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AuditId")
                        .HasColumnType("int");

                    b.Property<string>("AuditType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectExecutionStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectManagerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RemedialActionDuration")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("storeAuditResponses");
                });
#pragma warning restore 612, 618
        }
    }
}
