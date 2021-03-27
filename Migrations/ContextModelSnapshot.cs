﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using webshop.Models;

namespace webshop.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("webshop.Models.Option", b =>
                {
                    b.Property<int>("OptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.HasKey("OptionId");

                    b.ToTable("Option");

                    b.HasData(
                        new
                        {
                            OptionId = 1,
                            Name = "S",
                            Type = "Size"
                        },
                        new
                        {
                            OptionId = 2,
                            Name = "M",
                            Type = "Size"
                        },
                        new
                        {
                            OptionId = 3,
                            Name = "L",
                            Type = "Size"
                        },
                        new
                        {
                            OptionId = 4,
                            Name = "41",
                            Type = "ShoeSize"
                        },
                        new
                        {
                            OptionId = 6,
                            Name = "43",
                            Type = "ShoeSize"
                        },
                        new
                        {
                            OptionId = 5,
                            Name = "42",
                            Type = "ShoeSize"
                        },
                        new
                        {
                            OptionId = 7,
                            Name = "44",
                            Type = "ShoeSize"
                        },
                        new
                        {
                            OptionId = 9,
                            Name = "Red",
                            Type = "Color"
                        },
                        new
                        {
                            OptionId = 10,
                            Name = "Yellow",
                            Type = "Color"
                        },
                        new
                        {
                            OptionId = 11,
                            Name = "Blue",
                            Type = "Color"
                        },
                        new
                        {
                            OptionId = 12,
                            Name = "Dark Blue",
                            Type = "Color"
                        },
                        new
                        {
                            OptionId = 13,
                            Name = "Orange",
                            Type = "Color"
                        },
                        new
                        {
                            OptionId = 14,
                            Name = "Jeans",
                            Type = "Material"
                        },
                        new
                        {
                            OptionId = 15,
                            Name = "Cotton",
                            Type = "Material"
                        },
                        new
                        {
                            OptionId = 16,
                            Name = "Silk",
                            Type = "Material"
                        });
                });

            modelBuilder.Entity("webshop.Models.OptionGroup", b =>
                {
                    b.Property<int>("OptionGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("OptionGroupId");

                    b.HasIndex("ProductId");

                    b.ToTable("OptionGroup");

                    b.HasData(
                        new
                        {
                            OptionGroupId = 1,
                            ProductId = 1,
                            Quantity = 10
                        },
                        new
                        {
                            OptionGroupId = 2,
                            ProductId = 1,
                            Quantity = 10
                        });
                });

            modelBuilder.Entity("webshop.Models.OptionGroupOption", b =>
                {
                    b.Property<int>("OptionGroupId")
                        .HasColumnType("integer");

                    b.Property<int>("OptionId")
                        .HasColumnType("integer");

                    b.HasKey("OptionGroupId", "OptionId");

                    b.HasIndex("OptionId");

                    b.ToTable("OptionGroupOption");

                    b.HasData(
                        new
                        {
                            OptionGroupId = 1,
                            OptionId = 1
                        },
                        new
                        {
                            OptionGroupId = 1,
                            OptionId = 11
                        },
                        new
                        {
                            OptionGroupId = 1,
                            OptionId = 15
                        },
                        new
                        {
                            OptionGroupId = 2,
                            OptionId = 2
                        },
                        new
                        {
                            OptionGroupId = 2,
                            OptionId = 12
                        },
                        new
                        {
                            OptionGroupId = 2,
                            OptionId = 16
                        });
                });

            modelBuilder.Entity("webshop.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<decimal>("Wheight")
                        .HasColumnType("numeric");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Description = "Bergahus Corbeck jacket in purple/navy",
                            Image = "https://images.asos-media.com/products/bergahus-corbeck-jacket-in-purple-navy/23807356-1-purple?$XXL$&wid=513&fit=constrain",
                            Name = "Bergahus Corbeck jacket in purple/navy",
                            Price = 80m,
                            Quantity = 0,
                            Wheight = 200m
                        },
                        new
                        {
                            ProductId = 2,
                            Description = "Nike Running Quest 3 trainers in blue",
                            Image = "https://images.asos-media.com/products/nike-running-quest-3-trainers-in-blue/21248700-1-blue?$XXL$&wid=513&fit=constrain",
                            Name = "Nike Running Quest 3 trainers in blue",
                            Price = 100m,
                            Quantity = 0,
                            Wheight = 100m
                        },
                        new
                        {
                            ProductId = 3,
                            Description = "Nike Running Renew Run 2 trainers in light pink",
                            Image = "https://images.asos-media.com/products/nike-running-renew-run-2-trainers-in-light-pink/21249069-1-pink?$XXL$&wid=513&fit=constrain",
                            Name = "Nike Running Renew Run 2 trainers in light pink",
                            Price = 130m,
                            Quantity = 0,
                            Wheight = 250m
                        },
                        new
                        {
                            ProductId = 4,
                            Description = "Tommy Jeans high rise mom jean in dark wash",
                            Image = "https://images.asos-media.com/products/tommy-jeans-high-rise-mom-jean-in-dark-wash/21066878-1-tjsavefawbmix?$XXL$&wid=513&fit=constrain",
                            Name = "Tommy Jeans high rise mom jean in dark wash",
                            Price = 96m,
                            Quantity = 0,
                            Wheight = 200m
                        },
                        new
                        {
                            ProductId = 6,
                            Description = "Tommy Jeans cargo mom jean in lightwash blue",
                            Image = "https://images.asos-media.com/products/tommy-jeans-cargo-mom-jean-in-lightwash-blue/21762295-1-savepslbrigdest?$XXL$&wid=513&fit=constrain",
                            Name = "Tommy Jeans cargo mom jean in lightwash blue",
                            Price = 87m,
                            Quantity = 0,
                            Wheight = 150m
                        },
                        new
                        {
                            ProductId = 5,
                            Description = "BOSS Athleisure Tee 5 t-shirt in white",
                            Image = "https://images.asos-media.com/products/boss-athleisure-tee-5-t-shirt-in-white/23020696-1-white?$XXL$&wid=513&fit=constrain",
                            Name = "BOSS Athleisure Tee 5 t-shirt in white",
                            Price = 45m,
                            Quantity = 0,
                            Wheight = 80m
                        });
                });

            modelBuilder.Entity("webshop.Models.OptionGroup", b =>
                {
                    b.HasOne("webshop.Models.Product", "Product")
                        .WithMany("OptionGroup")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("webshop.Models.OptionGroupOption", b =>
                {
                    b.HasOne("webshop.Models.OptionGroup", "OptionGroup")
                        .WithMany("OptionLink")
                        .HasForeignKey("OptionGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webshop.Models.Option", "Option")
                        .WithMany("OptionGroupLink")
                        .HasForeignKey("OptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
