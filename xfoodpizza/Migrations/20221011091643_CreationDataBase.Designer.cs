﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using xfoodpizza.Data;

#nullable disable

namespace xfoodpizza.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221011091643_CreationDataBase")]
    partial class CreationDataBase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("xfoodpizza.Models.Pizza", b =>
                {
                    b.Property<int>("PizzaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PizzaID"), 1L, 1);

                    b.Property<string>("ingredients")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("prix")
                        .HasColumnType("real");

                    b.Property<bool>("vetarienne")
                        .HasColumnType("bit");

                    b.HasKey("PizzaID");

                    b.ToTable("Pizzas");
                });
#pragma warning restore 612, 618
        }
    }
}
