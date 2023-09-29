﻿// <auto-generated />
using System;
using EnvisionStudioPokemonAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EnvisionStudioPokemonAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230929193116_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("EnvisionStudioPokemonAPI.Models.Ability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Ability");
                });

            modelBuilder.Entity("EnvisionStudioPokemonAPI.Models.AbilityInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AbilityId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHidden")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PokemonDetailId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Slot")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AbilityId");

                    b.HasIndex("PokemonDetailId");

                    b.ToTable("AbilityInfo");
                });

            modelBuilder.Entity("EnvisionStudioPokemonAPI.Models.FavoritePokemon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PokemonDetailId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type2")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Weight")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PokemonDetailId");

                    b.ToTable("FavoritePokemons");
                });

            modelBuilder.Entity("EnvisionStudioPokemonAPI.Models.Move", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Move");
                });

            modelBuilder.Entity("EnvisionStudioPokemonAPI.Models.MoveInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MoveId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PokemonDetailId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MoveId");

                    b.HasIndex("PokemonDetailId");

                    b.ToTable("MoveInfo");
                });

            modelBuilder.Entity("EnvisionStudioPokemonAPI.Models.PokemonDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BaseExperience")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SpritesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Weight")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SpritesId");

                    b.ToTable("PokemonDetail");
                });

            modelBuilder.Entity("EnvisionStudioPokemonAPI.Models.Sprites", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BackDefault")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BackFemale")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BackShiny")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BackShinyFemale")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FrontDefault")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FrontFemale")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FrontShiny")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FrontShinyFemale")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Sprites");
                });

            modelBuilder.Entity("EnvisionStudioPokemonAPI.Models.Stat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Stat");
                });

            modelBuilder.Entity("EnvisionStudioPokemonAPI.Models.StatInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BaseStat")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Effort")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PokemonDetailId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StatId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PokemonDetailId");

                    b.HasIndex("StatId");

                    b.ToTable("StatInfo");
                });

            modelBuilder.Entity("EnvisionStudioPokemonAPI.Models.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Type");
                });

            modelBuilder.Entity("EnvisionStudioPokemonAPI.Models.TypeInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PokemonDetailId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Slot")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PokemonDetailId");

                    b.HasIndex("TypeId");

                    b.ToTable("TypeInfo");
                });

            modelBuilder.Entity("EnvisionStudioPokemonAPI.Models.AbilityInfo", b =>
                {
                    b.HasOne("EnvisionStudioPokemonAPI.Models.Ability", "Ability")
                        .WithMany()
                        .HasForeignKey("AbilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnvisionStudioPokemonAPI.Models.PokemonDetail", null)
                        .WithMany("Abilities")
                        .HasForeignKey("PokemonDetailId");

                    b.Navigation("Ability");
                });

            modelBuilder.Entity("EnvisionStudioPokemonAPI.Models.FavoritePokemon", b =>
                {
                    b.HasOne("EnvisionStudioPokemonAPI.Models.PokemonDetail", "PokemonDetail")
                        .WithMany()
                        .HasForeignKey("PokemonDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PokemonDetail");
                });

            modelBuilder.Entity("EnvisionStudioPokemonAPI.Models.MoveInfo", b =>
                {
                    b.HasOne("EnvisionStudioPokemonAPI.Models.Move", "Move")
                        .WithMany()
                        .HasForeignKey("MoveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnvisionStudioPokemonAPI.Models.PokemonDetail", null)
                        .WithMany("Moves")
                        .HasForeignKey("PokemonDetailId");

                    b.Navigation("Move");
                });

            modelBuilder.Entity("EnvisionStudioPokemonAPI.Models.PokemonDetail", b =>
                {
                    b.HasOne("EnvisionStudioPokemonAPI.Models.Sprites", "Sprites")
                        .WithMany()
                        .HasForeignKey("SpritesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sprites");
                });

            modelBuilder.Entity("EnvisionStudioPokemonAPI.Models.StatInfo", b =>
                {
                    b.HasOne("EnvisionStudioPokemonAPI.Models.PokemonDetail", null)
                        .WithMany("Stats")
                        .HasForeignKey("PokemonDetailId");

                    b.HasOne("EnvisionStudioPokemonAPI.Models.Stat", "Stat")
                        .WithMany()
                        .HasForeignKey("StatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stat");
                });

            modelBuilder.Entity("EnvisionStudioPokemonAPI.Models.TypeInfo", b =>
                {
                    b.HasOne("EnvisionStudioPokemonAPI.Models.PokemonDetail", null)
                        .WithMany("Types")
                        .HasForeignKey("PokemonDetailId");

                    b.HasOne("EnvisionStudioPokemonAPI.Models.Type", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });

            modelBuilder.Entity("EnvisionStudioPokemonAPI.Models.PokemonDetail", b =>
                {
                    b.Navigation("Abilities");

                    b.Navigation("Moves");

                    b.Navigation("Stats");

                    b.Navigation("Types");
                });
#pragma warning restore 612, 618
        }
    }
}