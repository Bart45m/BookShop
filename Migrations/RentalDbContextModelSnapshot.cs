﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rental.Data;

#nullable disable

namespace Rental.Migrations
{
    [DbContext(typeof(RentalDbContext))]
    partial class RentalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.27");

            modelBuilder.Entity("Rental.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            FirstName = "name1",
                            LastName = "surname1"
                        },
                        new
                        {
                            Id = 2,
                            BookId = 2,
                            FirstName = "name2",
                            LastName = "surname2"
                        },
                        new
                        {
                            Id = 3,
                            BookId = 3,
                            FirstName = "name3",
                            LastName = "surname3"
                        },
                        new
                        {
                            Id = 4,
                            BookId = 4,
                            FirstName = "name4",
                            LastName = "surname4"
                        },
                        new
                        {
                            Id = 5,
                            BookId = 5,
                            FirstName = "name5",
                            LastName = "surname5"
                        },
                        new
                        {
                            Id = 6,
                            BookId = 6,
                            FirstName = "name6",
                            LastName = "surname6"
                        },
                        new
                        {
                            Id = 7,
                            BookId = 7,
                            FirstName = "name7",
                            LastName = "surname7"
                        },
                        new
                        {
                            Id = 8,
                            BookId = 8,
                            FirstName = "name8",
                            LastName = "surname8"
                        },
                        new
                        {
                            Id = 9,
                            BookId = 9,
                            FirstName = "name9",
                            LastName = "surname9"
                        },
                        new
                        {
                            Id = 10,
                            BookId = 10,
                            FirstName = "name10",
                            LastName = "surname10"
                        },
                        new
                        {
                            Id = 11,
                            BookId = 1,
                            FirstName = "name11",
                            LastName = "surname11"
                        },
                        new
                        {
                            Id = 12,
                            BookId = 2,
                            FirstName = "name12",
                            LastName = "surname12"
                        },
                        new
                        {
                            Id = 13,
                            BookId = 3,
                            FirstName = "name13",
                            LastName = "surname13"
                        },
                        new
                        {
                            Id = 14,
                            BookId = 4,
                            FirstName = "name14",
                            LastName = "surname14"
                        },
                        new
                        {
                            Id = 15,
                            BookId = 5,
                            FirstName = "name15",
                            LastName = "surname15"
                        },
                        new
                        {
                            Id = 16,
                            BookId = 6,
                            FirstName = "name16",
                            LastName = "surname16"
                        },
                        new
                        {
                            Id = 17,
                            BookId = 7,
                            FirstName = "name17",
                            LastName = "surname17"
                        },
                        new
                        {
                            Id = 18,
                            BookId = 8,
                            FirstName = "name18",
                            LastName = "surname18"
                        },
                        new
                        {
                            Id = 19,
                            BookId = 9,
                            FirstName = "name19",
                            LastName = "surname19"
                        },
                        new
                        {
                            Id = 20,
                            BookId = 10,
                            FirstName = "name20",
                            LastName = "surname20"
                        });
                });

            modelBuilder.Entity("Rental.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Bookstand")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Shelf")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bookstand = 1,
                            Price = "10",
                            Shelf = 1,
                            Title = "title1"
                        },
                        new
                        {
                            Id = 2,
                            Bookstand = 2,
                            Price = "20",
                            Shelf = 2,
                            Title = "title2"
                        },
                        new
                        {
                            Id = 3,
                            Bookstand = 3,
                            Price = "30",
                            Shelf = 3,
                            Title = "title3"
                        },
                        new
                        {
                            Id = 4,
                            Bookstand = 4,
                            Price = "40",
                            Shelf = 4,
                            Title = "title4"
                        },
                        new
                        {
                            Id = 5,
                            Bookstand = 5,
                            Price = "50",
                            Shelf = 5,
                            Title = "title5"
                        },
                        new
                        {
                            Id = 6,
                            Bookstand = 6,
                            Price = "60",
                            Shelf = 6,
                            Title = "title6"
                        },
                        new
                        {
                            Id = 7,
                            Bookstand = 7,
                            Price = "70",
                            Shelf = 7,
                            Title = "title7"
                        },
                        new
                        {
                            Id = 8,
                            Bookstand = 8,
                            Price = "80",
                            Shelf = 8,
                            Title = "title8"
                        },
                        new
                        {
                            Id = 9,
                            Bookstand = 9,
                            Price = "90",
                            Shelf = 9,
                            Title = "title9"
                        },
                        new
                        {
                            Id = 10,
                            Bookstand = 10,
                            Price = "100",
                            Shelf = 10,
                            Title = "title10"
                        });
                });

            modelBuilder.Entity("Rental.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("OrderId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OrderId = "19b331c5-5665-4c02-914b-dde52072e33f",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            OrderId = "8e116c10-c40e-469a-95d4-7ab11c8515a1",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            OrderId = "27724367-651a-426c-8765-b75bdd29323b",
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            OrderId = "976b89b4-e8d2-4551-994c-0c9eb338d09f",
                            UserId = 4
                        },
                        new
                        {
                            Id = 5,
                            OrderId = "ba472e17-495f-40f0-bf73-c8e188c9ea7b",
                            UserId = 5
                        },
                        new
                        {
                            Id = 6,
                            OrderId = "cbb4c653-2ca4-494b-8b73-5fffdf3e6f9c",
                            UserId = 6
                        },
                        new
                        {
                            Id = 7,
                            OrderId = "6db03bdf-ef74-4dde-ad43-95da86832415",
                            UserId = 7
                        });
                });

            modelBuilder.Entity("Rental.Models.OrderLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderLine");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 2,
                            BookId = 1,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 3,
                            BookId = 1,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 4,
                            BookId = 1,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 5,
                            BookId = 1,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 6,
                            BookId = 2,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 7,
                            BookId = 2,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 8,
                            BookId = 2,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 9,
                            BookId = 2,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 10,
                            BookId = 2,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 11,
                            BookId = 3,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 12,
                            BookId = 3,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 13,
                            BookId = 3,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 14,
                            BookId = 3,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 15,
                            BookId = 3,
                            OrderId = 1
                        },
                        new
                        {
                            Id = 16,
                            BookId = 4,
                            OrderId = 2
                        },
                        new
                        {
                            Id = 17,
                            BookId = 4,
                            OrderId = 2
                        },
                        new
                        {
                            Id = 18,
                            BookId = 4,
                            OrderId = 2
                        },
                        new
                        {
                            Id = 19,
                            BookId = 4,
                            OrderId = 2
                        },
                        new
                        {
                            Id = 20,
                            BookId = 4,
                            OrderId = 2
                        },
                        new
                        {
                            Id = 21,
                            BookId = 5,
                            OrderId = 2
                        },
                        new
                        {
                            Id = 22,
                            BookId = 5,
                            OrderId = 2
                        },
                        new
                        {
                            Id = 23,
                            BookId = 5,
                            OrderId = 2
                        },
                        new
                        {
                            Id = 24,
                            BookId = 5,
                            OrderId = 2
                        },
                        new
                        {
                            Id = 25,
                            BookId = 5,
                            OrderId = 2
                        },
                        new
                        {
                            Id = 26,
                            BookId = 6,
                            OrderId = 2
                        },
                        new
                        {
                            Id = 27,
                            BookId = 6,
                            OrderId = 2
                        },
                        new
                        {
                            Id = 28,
                            BookId = 6,
                            OrderId = 2
                        },
                        new
                        {
                            Id = 29,
                            BookId = 6,
                            OrderId = 2
                        },
                        new
                        {
                            Id = 30,
                            BookId = 6,
                            OrderId = 2
                        },
                        new
                        {
                            Id = 31,
                            BookId = 7,
                            OrderId = 3
                        },
                        new
                        {
                            Id = 32,
                            BookId = 7,
                            OrderId = 3
                        },
                        new
                        {
                            Id = 33,
                            BookId = 7,
                            OrderId = 3
                        },
                        new
                        {
                            Id = 34,
                            BookId = 7,
                            OrderId = 3
                        },
                        new
                        {
                            Id = 35,
                            BookId = 7,
                            OrderId = 3
                        },
                        new
                        {
                            Id = 36,
                            BookId = 8,
                            OrderId = 3
                        },
                        new
                        {
                            Id = 37,
                            BookId = 8,
                            OrderId = 3
                        },
                        new
                        {
                            Id = 38,
                            BookId = 8,
                            OrderId = 3
                        },
                        new
                        {
                            Id = 39,
                            BookId = 8,
                            OrderId = 3
                        },
                        new
                        {
                            Id = 40,
                            BookId = 8,
                            OrderId = 3
                        },
                        new
                        {
                            Id = 41,
                            BookId = 9,
                            OrderId = 3
                        },
                        new
                        {
                            Id = 42,
                            BookId = 9,
                            OrderId = 3
                        },
                        new
                        {
                            Id = 43,
                            BookId = 9,
                            OrderId = 3
                        },
                        new
                        {
                            Id = 44,
                            BookId = 9,
                            OrderId = 3
                        },
                        new
                        {
                            Id = 45,
                            BookId = 9,
                            OrderId = 3
                        },
                        new
                        {
                            Id = 46,
                            BookId = 10,
                            OrderId = 4
                        },
                        new
                        {
                            Id = 47,
                            BookId = 10,
                            OrderId = 4
                        },
                        new
                        {
                            Id = 48,
                            BookId = 10,
                            OrderId = 4
                        },
                        new
                        {
                            Id = 49,
                            BookId = 10,
                            OrderId = 4
                        },
                        new
                        {
                            Id = 50,
                            BookId = 10,
                            OrderId = 4
                        },
                        new
                        {
                            Id = 51,
                            BookId = 1,
                            OrderId = 4
                        },
                        new
                        {
                            Id = 52,
                            BookId = 1,
                            OrderId = 4
                        },
                        new
                        {
                            Id = 53,
                            BookId = 1,
                            OrderId = 4
                        },
                        new
                        {
                            Id = 54,
                            BookId = 1,
                            OrderId = 4
                        },
                        new
                        {
                            Id = 55,
                            BookId = 1,
                            OrderId = 4
                        },
                        new
                        {
                            Id = 56,
                            BookId = 2,
                            OrderId = 4
                        },
                        new
                        {
                            Id = 57,
                            BookId = 2,
                            OrderId = 4
                        },
                        new
                        {
                            Id = 58,
                            BookId = 2,
                            OrderId = 4
                        },
                        new
                        {
                            Id = 59,
                            BookId = 2,
                            OrderId = 4
                        },
                        new
                        {
                            Id = 60,
                            BookId = 2,
                            OrderId = 4
                        },
                        new
                        {
                            Id = 61,
                            BookId = 3,
                            OrderId = 5
                        },
                        new
                        {
                            Id = 62,
                            BookId = 3,
                            OrderId = 5
                        },
                        new
                        {
                            Id = 63,
                            BookId = 3,
                            OrderId = 5
                        },
                        new
                        {
                            Id = 64,
                            BookId = 3,
                            OrderId = 5
                        },
                        new
                        {
                            Id = 65,
                            BookId = 3,
                            OrderId = 5
                        },
                        new
                        {
                            Id = 66,
                            BookId = 4,
                            OrderId = 5
                        },
                        new
                        {
                            Id = 67,
                            BookId = 4,
                            OrderId = 5
                        },
                        new
                        {
                            Id = 68,
                            BookId = 4,
                            OrderId = 5
                        },
                        new
                        {
                            Id = 69,
                            BookId = 4,
                            OrderId = 5
                        },
                        new
                        {
                            Id = 70,
                            BookId = 4,
                            OrderId = 5
                        },
                        new
                        {
                            Id = 71,
                            BookId = 5,
                            OrderId = 5
                        },
                        new
                        {
                            Id = 72,
                            BookId = 5,
                            OrderId = 5
                        },
                        new
                        {
                            Id = 73,
                            BookId = 5,
                            OrderId = 5
                        },
                        new
                        {
                            Id = 74,
                            BookId = 5,
                            OrderId = 5
                        },
                        new
                        {
                            Id = 75,
                            BookId = 5,
                            OrderId = 5
                        },
                        new
                        {
                            Id = 76,
                            BookId = 6,
                            OrderId = 6
                        },
                        new
                        {
                            Id = 77,
                            BookId = 6,
                            OrderId = 6
                        },
                        new
                        {
                            Id = 78,
                            BookId = 6,
                            OrderId = 6
                        },
                        new
                        {
                            Id = 79,
                            BookId = 6,
                            OrderId = 6
                        },
                        new
                        {
                            Id = 80,
                            BookId = 6,
                            OrderId = 6
                        },
                        new
                        {
                            Id = 81,
                            BookId = 7,
                            OrderId = 6
                        },
                        new
                        {
                            Id = 82,
                            BookId = 7,
                            OrderId = 6
                        },
                        new
                        {
                            Id = 83,
                            BookId = 7,
                            OrderId = 6
                        },
                        new
                        {
                            Id = 84,
                            BookId = 7,
                            OrderId = 6
                        },
                        new
                        {
                            Id = 85,
                            BookId = 7,
                            OrderId = 6
                        },
                        new
                        {
                            Id = 86,
                            BookId = 8,
                            OrderId = 6
                        },
                        new
                        {
                            Id = 87,
                            BookId = 8,
                            OrderId = 6
                        },
                        new
                        {
                            Id = 88,
                            BookId = 8,
                            OrderId = 6
                        },
                        new
                        {
                            Id = 89,
                            BookId = 8,
                            OrderId = 6
                        },
                        new
                        {
                            Id = 90,
                            BookId = 8,
                            OrderId = 6
                        },
                        new
                        {
                            Id = 91,
                            BookId = 9,
                            OrderId = 7
                        },
                        new
                        {
                            Id = 92,
                            BookId = 9,
                            OrderId = 7
                        },
                        new
                        {
                            Id = 93,
                            BookId = 9,
                            OrderId = 7
                        },
                        new
                        {
                            Id = 94,
                            BookId = 9,
                            OrderId = 7
                        },
                        new
                        {
                            Id = 95,
                            BookId = 9,
                            OrderId = 7
                        },
                        new
                        {
                            Id = 96,
                            BookId = 10,
                            OrderId = 7
                        },
                        new
                        {
                            Id = 97,
                            BookId = 10,
                            OrderId = 7
                        },
                        new
                        {
                            Id = 98,
                            BookId = 10,
                            OrderId = 7
                        },
                        new
                        {
                            Id = 99,
                            BookId = 10,
                            OrderId = 7
                        },
                        new
                        {
                            Id = 100,
                            BookId = 10,
                            OrderId = 7
                        });
                });

            modelBuilder.Entity("Rental.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "email1@email.com",
                            Name = "name1",
                            Password = "password1",
                            Role = 2
                        },
                        new
                        {
                            Id = 2,
                            Email = "email2@email.com",
                            Name = "name2",
                            Password = "password2",
                            Role = 2
                        },
                        new
                        {
                            Id = 3,
                            Email = "email3@email.com",
                            Name = "name3",
                            Password = "password3",
                            Role = 1
                        },
                        new
                        {
                            Id = 4,
                            Email = "email4@email.com",
                            Name = "name4",
                            Password = "password4",
                            Role = 1
                        },
                        new
                        {
                            Id = 5,
                            Email = "email5@email.com",
                            Name = "name5",
                            Password = "password5",
                            Role = 1
                        },
                        new
                        {
                            Id = 6,
                            Email = "email6@email.com",
                            Name = "name6",
                            Password = "password6",
                            Role = 1
                        },
                        new
                        {
                            Id = 7,
                            Email = "email7@email.com",
                            Name = "name7",
                            Password = "password7",
                            Role = 1
                        });
                });

            modelBuilder.Entity("Rental.Models.Author", b =>
                {
                    b.HasOne("Rental.Models.Book", "Book")
                        .WithMany("Authors")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Rental.Models.Order", b =>
                {
                    b.HasOne("Rental.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Rental.Models.OrderLine", b =>
                {
                    b.HasOne("Rental.Models.Book", "Book")
                        .WithMany("OrderLines")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rental.Models.Order", "Order")
                        .WithMany("OrderLines")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Rental.Models.Book", b =>
                {
                    b.Navigation("Authors");

                    b.Navigation("OrderLines");
                });

            modelBuilder.Entity("Rental.Models.Order", b =>
                {
                    b.Navigation("OrderLines");
                });

            modelBuilder.Entity("Rental.Models.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
