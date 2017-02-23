﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using GamesDBApp.Data;

namespace GamesDBApp.Migrations
{
    [DbContext(typeof(GamesContext))]
    [Migration("20170223033000_ohgodwhy")]
    partial class ohgodwhy
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1");

            modelBuilder.Entity("GamesDBApp.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Developer")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("Platform")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 100);

                    b.Property<double>("Rating");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 100);

                    b.HasKey("GameId");

                    b.ToTable("Game");
                });
        }
    }
}