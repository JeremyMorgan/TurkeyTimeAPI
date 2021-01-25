using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurkeyTimeAPI.Models;

namespace TurkeyTimeAPI.DAL
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<FoodItem> FoodItems { get; set; }

        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            optionsBuilder.UseSqlite($"Data Source = { path }/fooditems.db");
            //optionsBuilder.UseSqlite("Data Source=fooditems.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodItem>().HasData(
                new FoodItem() { Id = 1, Name = "Potato Chips", Person = "Jeremy", GlutenFree = false, Vegetarian = false },
                new FoodItem() { Id = 2, Name = "Green Bean Casserole", Person = "Amber", GlutenFree = false, Vegetarian = false }
                );
        }
    }
}
