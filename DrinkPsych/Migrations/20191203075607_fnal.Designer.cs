﻿// <auto-generated />
using System;
using DrinkPsych.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DrinkPsych.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191203075607_fnal")]
    partial class fnal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DrinkPsych.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.Property<string>("Description");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Alcoholic",
                            Description = "All alcoholic drinks"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Non-alcoholic",
                            Description = "All non-alcoholic drinks"
                        });
                });

            modelBuilder.Entity("DrinkPsych.Models.Drink", b =>
                {
                    b.Property<int>("DrinkId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID");

                    b.Property<string>("ImagePath");

                    b.Property<string>("ImageThumbnailPath");

                    b.Property<bool>("InStock");

                    b.Property<bool>("IsPreferredDrink");

                    b.Property<string>("LongDescription");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("ShortDescription");

                    b.HasKey("DrinkId");

                    b.HasIndex("CategoryID");

                    b.ToTable("Drinks");

                    b.HasData(
                        new
                        {
                            DrinkId = 1,
                            CategoryID = 1,
                            ImagePath = "http://imgh.us/beerL_2.jpg",
                            ImageThumbnailPath = "https://www.marketexpert24.com/wp-content/uploads/2019/11/beer.jpeg",
                            InStock = true,
                            IsPreferredDrink = true,
                            LongDescription = "Beer is the world's oldest[1][2][3] and most widely consumed[4] alcoholic drink; it is the third most popular drink overall, after water and tea.[5] The production of beer is called brewing, which involves the fermentation of starches, mainly derived from cereal grains—most commonly malted barley, although wheat, maize (corn), and rice are widely used.[6] Most beer is flavoured with hops, which add bitterness and act as a natural preservative, though other flavourings such as herbs or fruit may occasionally be included. The fermentation process causes a natural carbonation effect, although this is often removed during processing, and replaced with forced carbonation.[7] Some of humanity's earliest known writings refer to the production and distribution of beer: the Code of Hammurabi included laws regulating beer and beer parlours.",
                            Name = "Beer",
                            Price = 7.95m,
                            ShortDescription = "The most widely consumed alcohol"
                        },
                        new
                        {
                            DrinkId = 2,
                            CategoryID = 1,
                            ImagePath = "http://imgh.us/rumCokeL.jpg",
                            ImageThumbnailPath = "https://www.umami.site/wp-content/uploads/2016/03/rum-coke-2.jpg",
                            InStock = true,
                            IsPreferredDrink = false,
                            LongDescription = "The world's second most popular drink was born in a collision between the United States and Spain. It happened during the Spanish-American War at the turn of the century when Teddy Roosevelt, the Rough Riders, and Americans in large numbers arrived in Cuba. One afternoon, a group of off-duty soldiers from the U.S. Signal Corps were gathered in a bar in Old Havana. Fausto Rodriguez, a young messenger, later recalled that Captain Russell came in and ordered Bacardi (Gold) rum and Coca-Cola on ice with a wedge of lime. The captain drank the concoction with such pleasure that it sparked the interest of the soldiers around him. They had the bartender prepare a round of the captain's drink for them. The Bacardi rum and Coke was an instant hit. As it does to this day, the drink united the crowd in a spirit of fun and good fellowship. When they ordered another round, one soldier suggested that they toast ¡Por Cuba Libre! in celebration of the newly freed Cuba.",
                            Name = "Rum & Coke",
                            Price = 12.95m,
                            ShortDescription = "Cocktail made of cola, lime and rum."
                        },
                        new
                        {
                            DrinkId = 3,
                            CategoryID = 1,
                            ImagePath = "http://imgh.us/tequilaL.jpg",
                            ImageThumbnailPath = "https://upload.wikimedia.org/wikipedia/commons/c/cf/15-09-26-RalfR-WLC-0244.jpg",
                            InStock = true,
                            IsPreferredDrink = false,
                            LongDescription = "Tequila (Spanish About this sound [teˈkila] (help·info)) is a regionally specific name for a distilled beverage made from the blue agave plant, primarily in the area surrounding the city of Tequila, 65 km (40 mi) northwest of Guadalajara, and in the highlands (Los Altos) of the central western Mexican state of Jalisco. Although tequila is similar to mezcal, modern tequila differs somewhat in the method of its production, in the use of only blue agave plants, as well as in its regional specificity. Tequila is commonly served neat in Mexico and as a shot with salt and lime across the rest of the world.The red volcanic soil in the surrounding region is particularly well suited to the growing of the blue agave, and more than 300 million of the plants are harvested there each year.[1] Agave tequila grows differently depending on the region. Blue agaves grown in the highlands Los Altos region are larger in size and sweeter in aroma and taste. Agaves harvested in the lowlands, on the other hand, have a more herbaceous fragrance and flavor.",
                            Name = "Tequila ",
                            Price = 12.95m,
                            ShortDescription = "Beverage made from the blue agave plant."
                        },
                        new
                        {
                            DrinkId = 4,
                            CategoryID = 1,
                            ImagePath = "http://imgh.us/wineL.jpg",
                            ImageThumbnailPath = "https://cdn-a.william-reed.com/var/wrbm_gb_food_pharma/storage/images/publications/food-beverage-nutrition/beveragedaily.com/article/2019/08/20/bottled-wine-narrowly-beats-out-canned-wine-in-flavor/10047400-1-eng-GB/Bottled-wine-narrowly-beats-out-canned-wine-in-flavor_wrbm_large.jpg",
                            InStock = true,
                            IsPreferredDrink = false,
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Name = "Wine ",
                            Price = 16.75m,
                            ShortDescription = "A very elegant alcoholic drink"
                        },
                        new
                        {
                            DrinkId = 5,
                            CategoryID = 1,
                            ImagePath = "http://imgh.us/margaritaL.jpg",
                            ImageThumbnailPath = "http://www.telegraph.co.uk/content/dam/food-and-drink/2016/02/22/margaritamain-xxlarge_trans_NvBQzQNjv4Bqeo_i_u9APj8RuoebjoAHt0k9u7HhRJvuo-ZLenGRumA.jpg",
                            InStock = true,
                            IsPreferredDrink = false,
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Name = "Margarita",
                            Price = 17.95m,
                            ShortDescription = "A cocktail with sec, tequila and lime"
                        },
                        new
                        {
                            DrinkId = 6,
                            CategoryID = 1,
                            ImagePath = "http://imgh.us/whiskyIceL.jpg",
                            ImageThumbnailPath = "https://assets3.thrillist.com/v1/image/2704804/size/tmg-article_default_mobile.jpg",
                            InStock = false,
                            IsPreferredDrink = false,
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Name = "Whiskey with Ice",
                            Price = 15.95m,
                            ShortDescription = "The best way to taste whiskey"
                        },
                        new
                        {
                            DrinkId = 7,
                            CategoryID = 1,
                            ImagePath = "http://imgh.us/champagneL.jpg",
                            ImageThumbnailPath = "https://cdn-image.foodandwine.com/sites/default/files/1572023471/108-year-old-champagne-FT-BLOG1019.jpg",
                            InStock = false,
                            IsPreferredDrink = false,
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Name = "Champagne",
                            Price = 15.95m,
                            ShortDescription = "That is how sparkling wine can be called"
                        },
                        new
                        {
                            DrinkId = 8,
                            CategoryID = 1,
                            ImagePath = "http://imgh.us/whiteRussianL.jpg",
                            ImageThumbnailPath = "https://www.inspiredtaste.net/wp-content/uploads/2011/10/White-Russian-Cocktail-Recipe-1-1200.jpg",
                            InStock = false,
                            IsPreferredDrink = false,
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Name = "White Russian",
                            Price = 15.95m,
                            ShortDescription = "A cocktail made with vodka "
                        },
                        new
                        {
                            DrinkId = 9,
                            CategoryID = 1,
                            ImagePath = "http://imgh.us/vodkaL.jpg",
                            ImageThumbnailPath = "https://www.licorea.com/images/magictoolbox_cache/feabb61ae2a71c1844359f7cbe8b5d82/1/4/1472/original/2901628488/absolut_4.5litros.jpg",
                            InStock = false,
                            IsPreferredDrink = false,
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Name = "Vodka",
                            Price = 15.95m,
                            ShortDescription = "A distilled beverage with water and ethanol."
                        },
                        new
                        {
                            DrinkId = 10,
                            CategoryID = 1,
                            ImagePath = "http://imgh.us/ginTonicL.jpg",
                            ImageThumbnailPath = "https://www.thespruceeats.com/thmb/8rtDjB-YdRW-RLVCEckIl6uoof8=/960x0/filters:no_upscale():max_bytes(150000):strip_icc()/gin-tonic-5a8f334b8e1b6e0036a9631d.jpg",
                            InStock = false,
                            IsPreferredDrink = false,
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Name = "Gin and tonic",
                            Price = 15.95m,
                            ShortDescription = "Made with gin and tonic water poured over ice."
                        },
                        new
                        {
                            DrinkId = 11,
                            CategoryID = 1,
                            ImagePath = "http://imgh.us/cosmopolitanL.jpg",
                            ImageThumbnailPath = "https://www.ndtv.com/cooks/images/cosmo-new.jpg",
                            InStock = false,
                            IsPreferredDrink = false,
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Name = "Cosmopolitan",
                            Price = 15.95m,
                            ShortDescription = "Made with vodka, triple sec, cranberry juice."
                        },
                        new
                        {
                            DrinkId = 12,
                            CategoryID = 2,
                            ImagePath = "http://imgh.us/teaL.jpg",
                            ImageThumbnailPath = "https://ichef.bbci.co.uk/news/1024/cpsprodpb/DA29/production/_108994855_teabag-index-getty5.jpg",
                            InStock = true,
                            IsPreferredDrink = true,
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Name = "Tea ",
                            Price = 12.95m,
                            ShortDescription = "Made by leaves of the tea plant in hot water."
                        },
                        new
                        {
                            DrinkId = 13,
                            CategoryID = 2,
                            ImagePath = "http://imgh.us/waterL.jpg",
                            ImageThumbnailPath = "https://static.toiimg.com/photo/70724157.cms",
                            InStock = true,
                            IsPreferredDrink = false,
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Name = "Water ",
                            Price = 12.95m,
                            ShortDescription = " It makes up more than half of your body weight "
                        },
                        new
                        {
                            DrinkId = 14,
                            CategoryID = 2,
                            ImagePath = "http://imgh.us/coffeeL.jpg",
                            ImageThumbnailPath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQCi2tUjnlVjN5EGPErvNg_i7cGhPGLGFzo-A5_ujp-V6QqBjDs&s",
                            InStock = true,
                            IsPreferredDrink = true,
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Name = "Coffee",
                            Price = 12.95m,
                            ShortDescription = " A beverage prepared from coffee beans"
                        },
                        new
                        {
                            DrinkId = 15,
                            CategoryID = 2,
                            ImagePath = "http://imgh.us/kvassL.jpg",
                            ImageThumbnailPath = "http://www.beetsandbones.com/wp-content/uploads/2015/09/apple-kvass.jpg",
                            InStock = true,
                            IsPreferredDrink = false,
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Name = "Kvass",
                            Price = 12.95m,
                            ShortDescription = "A very refreshing Russian beverage"
                        },
                        new
                        {
                            DrinkId = 16,
                            CategoryID = 2,
                            ImagePath = "http://imgh.us/juiceL.jpg",
                            ImageThumbnailPath = "https://ifu.site-ym.com/resource/resmgr/hphero/fruit_and_juice_main3.png",
                            InStock = true,
                            IsPreferredDrink = false,
                            LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                            Name = "Juice ",
                            Price = 12.95m,
                            ShortDescription = "Naturally contained in fruit or vegetable tissue."
                        });
                });

            modelBuilder.Entity("DrinkPsych.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(100);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("OrderPlace");

                    b.Property<decimal>("OrderTotal");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("State")
                        .HasMaxLength(10);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DrinkPsych.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<int>("DrinkId");

                    b.Property<int>("OrderId");

                    b.Property<decimal>("Price");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("DrinkId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("DrinkPsych.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<int?>("DrinkId");

                    b.Property<string>("ShoppingCartId");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("DrinkId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("DrinkPsych.Models.Drink", b =>
                {
                    b.HasOne("DrinkPsych.Models.Category", "Category")
                        .WithMany("Drinks")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DrinkPsych.Models.OrderDetail", b =>
                {
                    b.HasOne("DrinkPsych.Models.Drink", "Drink")
                        .WithMany()
                        .HasForeignKey("DrinkId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DrinkPsych.Models.Order", "Order")
                        .WithMany("OrderLines")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DrinkPsych.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("DrinkPsych.Models.Drink", "Drink")
                        .WithMany()
                        .HasForeignKey("DrinkId");
                });
#pragma warning restore 612, 618
        }
    }
}
