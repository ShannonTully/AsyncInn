using Microsoft.EntityFrameworkCore;
using AsyncInn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data
{
    public class AsyncDbContext : DbContext
    {
        public AsyncDbContext(DbContextOptions<AsyncDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomAmenities>().HasKey(ra => new { ra.AmenitiesID, ra.RoomID });
            modelBuilder.Entity<HotelRoom>().HasKey(hr => new { hr.HotelID, hr.RoomNumber });

            modelBuilder.Entity<Hotel>().HasData(
               new Hotel
               {
                   ID = 1,
                   Name = "place1",
                   StreetAddress = "1 0th st",
                   City = "city1",
                   State = "state1",
                   Phone = "111",
               },
               new Hotel
               {
                   ID = 2,
                   Name = "place2",
                   StreetAddress = "2 0th st",
                   City = "city2",
                   State = "state2",
                   Phone = "222",
               },
               new Hotel
               {
                   ID = 3,
                   Name = "place3",
                   StreetAddress = "3 0th st",
                   City = "city3",
                   State = "state3",
                   Phone = "333",
               },
               new Hotel
               {
                   ID = 4,
                   Name = "place4",
                   StreetAddress = "4 0th st",
                   City = "city4",
                   State = "state4",
                   Phone = "444",
               },
               new Hotel
               {
                   ID = 5,
                   Name = "place5",
                   StreetAddress = "5 0th st",
                   City = "city5",
                   State = "state5",
                   Phone = "555",
               }
               );

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    ID = 1,
                    Name = "room1",
                    Layout = 1,
                },
                new Room
                {
                    ID = 2,
                    Name = "room2",
                    Layout = 2,
                },
                new Room
                {
                    ID = 6,
                    Name = "room6",
                    Layout = 6,
                },
                new Room
                {
                    ID = 3,
                    Name = "room3",
                    Layout = 3,
                },
                new Room
                {
                    ID = 4,
                    Name = "room4",
                    Layout = 4,
                },
                new Room
                {
                    ID = 5,
                    Name = "room5",
                    Layout = 5,
                }
               );

            modelBuilder.Entity<Amenities>().HasData(
                new Amenities
                {
                    ID = 1,
                    Name = "Amenities1",
                },
                new Amenities
                {
                    ID = 2,
                    Name = "Amenities2",
                },
                new Amenities
                {
                    ID = 3,
                    Name = "Amenities3",
                },
                new Amenities
                {
                    ID = 4,
                    Name = "Amenities4",
                },
                new Amenities
                {
                    ID = 5,
                    Name = "Amenities5",
                }
               );
        }

        public DbSet<Room> Room { get; set; }
        public DbSet<RoomAmenities> RoomAmenities { get; set; }
        public DbSet<Amenities> Amenities { get; set; }
        public DbSet<HotelRoom> HotelRoom { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
    }
}
