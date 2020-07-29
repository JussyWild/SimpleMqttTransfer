﻿// <auto-generated />
using System;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Database.Migrations
{
    [DbContext(typeof(CalculationContext))]
    partial class CalculationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Database.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Payload")
                        .HasColumnName("payload")
                        .HasColumnType("text");

                    b.Property<long>("Qos")
                        .HasColumnName("qos")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ReceivedAt")
                        .HasColumnName("received_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Retain")
                        .HasColumnName("retain")
                        .HasColumnType("boolean");

                    b.Property<string>("Topic")
                        .HasColumnName("topic")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Topic");

                    b.ToTable("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
