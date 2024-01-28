﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecipesApi.Models;

#nullable disable

namespace RecipesApi.Migrations
{
    [DbContext(typeof(RecipesContext))]
    [Migration("20240128180919_SeedAllAttempt4")]
    partial class SeedAllAttempt4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("IngredientRecipe", b =>
                {
                    b.Property<long>("IngredientsId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("RecipesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("IngredientsId", "RecipesId");

                    b.HasIndex("RecipesId");

                    b.ToTable("IngredientRecipe");
                });

            modelBuilder.Entity("RecipeIngredients", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("IngredientId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<long>("RecipeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeIngredients");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            IngredientId = 7L,
                            Quantity = 15,
                            RecipeId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            IngredientId = 6L,
                            Quantity = 2,
                            RecipeId = 1L
                        },
                        new
                        {
                            Id = 3L,
                            IngredientId = 12L,
                            Quantity = 18,
                            RecipeId = 1L
                        },
                        new
                        {
                            Id = 4L,
                            IngredientId = 2L,
                            Quantity = 14,
                            RecipeId = 1L
                        },
                        new
                        {
                            Id = 5L,
                            IngredientId = 4L,
                            Quantity = 12,
                            RecipeId = 1L
                        },
                        new
                        {
                            Id = 6L,
                            IngredientId = 14L,
                            Quantity = 9,
                            RecipeId = 1L
                        },
                        new
                        {
                            Id = 7L,
                            IngredientId = 10L,
                            Quantity = 15,
                            RecipeId = 1L
                        },
                        new
                        {
                            Id = 8L,
                            IngredientId = 13L,
                            Quantity = 7,
                            RecipeId = 1L
                        },
                        new
                        {
                            Id = 9L,
                            IngredientId = 16L,
                            Quantity = 17,
                            RecipeId = 2L
                        },
                        new
                        {
                            Id = 10L,
                            IngredientId = 8L,
                            Quantity = 8,
                            RecipeId = 2L
                        },
                        new
                        {
                            Id = 11L,
                            IngredientId = 13L,
                            Quantity = 14,
                            RecipeId = 2L
                        },
                        new
                        {
                            Id = 12L,
                            IngredientId = 11L,
                            Quantity = 11,
                            RecipeId = 2L
                        },
                        new
                        {
                            Id = 13L,
                            IngredientId = 11L,
                            Quantity = 7,
                            RecipeId = 3L
                        },
                        new
                        {
                            Id = 14L,
                            IngredientId = 18L,
                            Quantity = 19,
                            RecipeId = 3L
                        },
                        new
                        {
                            Id = 15L,
                            IngredientId = 15L,
                            Quantity = 17,
                            RecipeId = 3L
                        },
                        new
                        {
                            Id = 16L,
                            IngredientId = 10L,
                            Quantity = 17,
                            RecipeId = 3L
                        },
                        new
                        {
                            Id = 17L,
                            IngredientId = 21L,
                            Quantity = 1,
                            RecipeId = 3L
                        },
                        new
                        {
                            Id = 18L,
                            IngredientId = 3L,
                            Quantity = 6,
                            RecipeId = 3L
                        },
                        new
                        {
                            Id = 19L,
                            IngredientId = 11L,
                            Quantity = 9,
                            RecipeId = 4L
                        },
                        new
                        {
                            Id = 20L,
                            IngredientId = 22L,
                            Quantity = 7,
                            RecipeId = 4L
                        },
                        new
                        {
                            Id = 21L,
                            IngredientId = 3L,
                            Quantity = 13,
                            RecipeId = 4L
                        },
                        new
                        {
                            Id = 22L,
                            IngredientId = 19L,
                            Quantity = 4,
                            RecipeId = 4L
                        },
                        new
                        {
                            Id = 23L,
                            IngredientId = 21L,
                            Quantity = 8,
                            RecipeId = 4L
                        },
                        new
                        {
                            Id = 24L,
                            IngredientId = 25L,
                            Quantity = 17,
                            RecipeId = 4L
                        },
                        new
                        {
                            Id = 25L,
                            IngredientId = 7L,
                            Quantity = 16,
                            RecipeId = 4L
                        },
                        new
                        {
                            Id = 26L,
                            IngredientId = 24L,
                            Quantity = 14,
                            RecipeId = 4L
                        },
                        new
                        {
                            Id = 27L,
                            IngredientId = 1L,
                            Quantity = 6,
                            RecipeId = 4L
                        },
                        new
                        {
                            Id = 28L,
                            IngredientId = 5L,
                            Quantity = 6,
                            RecipeId = 4L
                        },
                        new
                        {
                            Id = 29L,
                            IngredientId = 16L,
                            Quantity = 14,
                            RecipeId = 5L
                        },
                        new
                        {
                            Id = 30L,
                            IngredientId = 22L,
                            Quantity = 7,
                            RecipeId = 5L
                        },
                        new
                        {
                            Id = 31L,
                            IngredientId = 10L,
                            Quantity = 4,
                            RecipeId = 5L
                        },
                        new
                        {
                            Id = 32L,
                            IngredientId = 14L,
                            Quantity = 19,
                            RecipeId = 5L
                        },
                        new
                        {
                            Id = 33L,
                            IngredientId = 25L,
                            Quantity = 10,
                            RecipeId = 5L
                        },
                        new
                        {
                            Id = 34L,
                            IngredientId = 9L,
                            Quantity = 4,
                            RecipeId = 6L
                        },
                        new
                        {
                            Id = 35L,
                            IngredientId = 21L,
                            Quantity = 16,
                            RecipeId = 6L
                        },
                        new
                        {
                            Id = 36L,
                            IngredientId = 22L,
                            Quantity = 5,
                            RecipeId = 6L
                        },
                        new
                        {
                            Id = 37L,
                            IngredientId = 14L,
                            Quantity = 10,
                            RecipeId = 6L
                        },
                        new
                        {
                            Id = 38L,
                            IngredientId = 11L,
                            Quantity = 10,
                            RecipeId = 6L
                        },
                        new
                        {
                            Id = 39L,
                            IngredientId = 15L,
                            Quantity = 1,
                            RecipeId = 6L
                        },
                        new
                        {
                            Id = 40L,
                            IngredientId = 16L,
                            Quantity = 4,
                            RecipeId = 7L
                        },
                        new
                        {
                            Id = 41L,
                            IngredientId = 23L,
                            Quantity = 12,
                            RecipeId = 7L
                        },
                        new
                        {
                            Id = 42L,
                            IngredientId = 5L,
                            Quantity = 5,
                            RecipeId = 7L
                        },
                        new
                        {
                            Id = 43L,
                            IngredientId = 18L,
                            Quantity = 15,
                            RecipeId = 7L
                        },
                        new
                        {
                            Id = 44L,
                            IngredientId = 21L,
                            Quantity = 5,
                            RecipeId = 7L
                        },
                        new
                        {
                            Id = 45L,
                            IngredientId = 24L,
                            Quantity = 19,
                            RecipeId = 7L
                        },
                        new
                        {
                            Id = 46L,
                            IngredientId = 25L,
                            Quantity = 13,
                            RecipeId = 7L
                        },
                        new
                        {
                            Id = 47L,
                            IngredientId = 14L,
                            Quantity = 13,
                            RecipeId = 8L
                        },
                        new
                        {
                            Id = 48L,
                            IngredientId = 6L,
                            Quantity = 3,
                            RecipeId = 8L
                        },
                        new
                        {
                            Id = 49L,
                            IngredientId = 25L,
                            Quantity = 1,
                            RecipeId = 8L
                        },
                        new
                        {
                            Id = 50L,
                            IngredientId = 19L,
                            Quantity = 11,
                            RecipeId = 8L
                        },
                        new
                        {
                            Id = 51L,
                            IngredientId = 8L,
                            Quantity = 3,
                            RecipeId = 9L
                        },
                        new
                        {
                            Id = 52L,
                            IngredientId = 14L,
                            Quantity = 2,
                            RecipeId = 9L
                        },
                        new
                        {
                            Id = 53L,
                            IngredientId = 17L,
                            Quantity = 4,
                            RecipeId = 9L
                        },
                        new
                        {
                            Id = 54L,
                            IngredientId = 15L,
                            Quantity = 3,
                            RecipeId = 9L
                        },
                        new
                        {
                            Id = 55L,
                            IngredientId = 25L,
                            Quantity = 18,
                            RecipeId = 9L
                        },
                        new
                        {
                            Id = 56L,
                            IngredientId = 10L,
                            Quantity = 12,
                            RecipeId = 10L
                        },
                        new
                        {
                            Id = 57L,
                            IngredientId = 23L,
                            Quantity = 18,
                            RecipeId = 10L
                        },
                        new
                        {
                            Id = 58L,
                            IngredientId = 1L,
                            Quantity = 2,
                            RecipeId = 10L
                        },
                        new
                        {
                            Id = 59L,
                            IngredientId = 25L,
                            Quantity = 4,
                            RecipeId = 10L
                        },
                        new
                        {
                            Id = 60L,
                            IngredientId = 11L,
                            Quantity = 13,
                            RecipeId = 10L
                        });
                });

            modelBuilder.Entity("RecipesApi.Models.Chef", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Chefs");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Gordron Ramsey"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "Rachael Ray"
                        },
                        new
                        {
                            Id = 3L,
                            Name = "Ainsley Harriott"
                        },
                        new
                        {
                            Id = 4L,
                            Name = "Matty Matheson"
                        },
                        new
                        {
                            Id = 5L,
                            Name = "Rick Stein"
                        },
                        new
                        {
                            Id = 6L,
                            Name = "Carla Hall"
                        });
                });

            modelBuilder.Entity("RecipesApi.Models.Ingredient", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Stock")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "onion",
                            Stock = 35
                        },
                        new
                        {
                            Id = 2L,
                            Name = "carrot",
                            Stock = 23
                        },
                        new
                        {
                            Id = 3L,
                            Name = "parsnip",
                            Stock = 16
                        },
                        new
                        {
                            Id = 4L,
                            Name = "garlic",
                            Stock = 32
                        },
                        new
                        {
                            Id = 5L,
                            Name = "celery",
                            Stock = 12
                        },
                        new
                        {
                            Id = 6L,
                            Name = "potato",
                            Stock = 26
                        },
                        new
                        {
                            Id = 7L,
                            Name = "tomato",
                            Stock = 100
                        },
                        new
                        {
                            Id = 8L,
                            Name = "courgette",
                            Stock = 32
                        },
                        new
                        {
                            Id = 9L,
                            Name = "aubergine",
                            Stock = 25
                        },
                        new
                        {
                            Id = 10L,
                            Name = "pepper",
                            Stock = 12
                        },
                        new
                        {
                            Id = 11L,
                            Name = "pasta",
                            Stock = 15
                        },
                        new
                        {
                            Id = 12L,
                            Name = "flour",
                            Stock = 35
                        },
                        new
                        {
                            Id = 13L,
                            Name = "egg",
                            Stock = 21
                        },
                        new
                        {
                            Id = 14L,
                            Name = "water",
                            Stock = 19
                        },
                        new
                        {
                            Id = 15L,
                            Name = "yeast",
                            Stock = 17
                        },
                        new
                        {
                            Id = 16L,
                            Name = "salt",
                            Stock = 20
                        },
                        new
                        {
                            Id = 17L,
                            Name = "basil",
                            Stock = 11
                        },
                        new
                        {
                            Id = 18L,
                            Name = "olive oil",
                            Stock = 15
                        },
                        new
                        {
                            Id = 19L,
                            Name = "black pepper",
                            Stock = 24
                        },
                        new
                        {
                            Id = 20L,
                            Name = "parmesan",
                            Stock = 25
                        },
                        new
                        {
                            Id = 21L,
                            Name = "mozzerella",
                            Stock = 22
                        },
                        new
                        {
                            Id = 22L,
                            Name = "chocolate",
                            Stock = 17
                        },
                        new
                        {
                            Id = 23L,
                            Name = "sugar",
                            Stock = 32
                        },
                        new
                        {
                            Id = 24L,
                            Name = "butter",
                            Stock = 31
                        },
                        new
                        {
                            Id = 25L,
                            Name = "strawberry",
                            Stock = 29
                        });
                });

            modelBuilder.Entity("RecipesApi.Models.Recipe", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("ChefId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsFavourite")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Secret")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ChefId");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            ChefId = 1L,
                            IsFavourite = true,
                            Name = "sunday special",
                            Secret = "don't over boil the sauce"
                        },
                        new
                        {
                            Id = 2L,
                            ChefId = 2L,
                            IsFavourite = false,
                            Name = "evening delight",
                            Secret = "timing"
                        },
                        new
                        {
                            Id = 3L,
                            ChefId = 2L,
                            IsFavourite = true,
                            Name = "the welsh",
                            Secret = "cook pasta in sauce"
                        },
                        new
                        {
                            Id = 4L,
                            ChefId = 3L,
                            IsFavourite = false,
                            Name = "runners company",
                            Secret = "consider moisture"
                        },
                        new
                        {
                            Id = 5L,
                            ChefId = 3L,
                            IsFavourite = true,
                            Name = "kids plate",
                            Secret = "hot oven"
                        },
                        new
                        {
                            Id = 6L,
                            ChefId = 4L,
                            IsFavourite = false,
                            Name = "dogs dinner",
                            Secret = "don't overbake"
                        },
                        new
                        {
                            Id = 7L,
                            ChefId = 5L,
                            IsFavourite = true,
                            Name = "left overs",
                            Secret = "cheese on every layer"
                        },
                        new
                        {
                            Id = 8L,
                            ChefId = 6L,
                            IsFavourite = false,
                            Name = "monday blues",
                            Secret = "don't over cook the veg"
                        },
                        new
                        {
                            Id = 9L,
                            ChefId = 6L,
                            IsFavourite = true,
                            Name = "the stinker",
                            Secret = "make em gooey"
                        },
                        new
                        {
                            Id = 10L,
                            ChefId = 6L,
                            IsFavourite = false,
                            Name = "deutch courage",
                            Secret = "cut the veg big"
                        });
                });

            modelBuilder.Entity("IngredientRecipe", b =>
                {
                    b.HasOne("RecipesApi.Models.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecipesApi.Models.Recipe", null)
                        .WithMany()
                        .HasForeignKey("RecipesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RecipeIngredients", b =>
                {
                    b.HasOne("RecipesApi.Models.Ingredient", null)
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecipesApi.Models.Recipe", null)
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RecipesApi.Models.Recipe", b =>
                {
                    b.HasOne("RecipesApi.Models.Chef", "Chef")
                        .WithMany("Recipes")
                        .HasForeignKey("ChefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chef");
                });

            modelBuilder.Entity("RecipesApi.Models.Chef", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("RecipesApi.Models.Ingredient", b =>
                {
                    b.Navigation("RecipeIngredients");
                });

            modelBuilder.Entity("RecipesApi.Models.Recipe", b =>
                {
                    b.Navigation("RecipeIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}
