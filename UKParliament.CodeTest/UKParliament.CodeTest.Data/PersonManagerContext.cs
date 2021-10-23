using System;
using Microsoft.EntityFrameworkCore;
using UKParliament.CodeTest.Domain;

namespace UKParliament.CodeTest.Data
{
    public class PersonManagerContext : DbContext
    {
        public PersonManagerContext(DbContextOptions<PersonManagerContext> options)
            : base(options)
        {
        }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Person person = new Person()
            {
                Id = 1,
                Name = "Alice",
                FavouriteIceCream = "Strawberry",
                Address = "1 The Avenue, London",
                DateOfBirth = DateTime.Now.AddYears(-30)
            };

            Person person2 = new Person()
            {
                Id = 2,
                Name = "Bob",
                FavouriteIceCream = "Salted Caramel",
                Address = "2, The Cliffs, Brighton",
                DateOfBirth = DateTime.Now.AddYears(-35)
            };

            Person person3 = new Person()
            {
                Id = 3,
                Name = "Claire",
                FavouriteIceCream = "Crunchie Blast",
                Address = "3, The College, Oxford",
                DateOfBirth = DateTime.Now.AddYears(-55)
            };

            modelBuilder.Entity<Person>().HasData(person, person2, person3);

        }
    }
}
