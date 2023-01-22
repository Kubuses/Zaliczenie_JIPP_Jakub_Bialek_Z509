﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Zaliczenie_JIPP_Jakub_Bialek.Data;

namespace Zaliczenie_JIPP_Jakub_Bialek.Migrations
{
    [DbContext(typeof(ProgrammingBookContext))]
    partial class ProgrammingBookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Zaliczenie_JIPP_Jakub_Bialek.Models.ProgrammingBookModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<int>("PublishYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("ProgrammingBooks");
                });
#pragma warning restore 612, 618
        }
    }
}