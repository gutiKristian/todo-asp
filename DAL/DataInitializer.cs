using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    // Static class cannot be instantiated
    internal static class DataInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Collections
            var itemCollection = new ItemCollection { Id = 1, Name = "Study"};
            modelBuilder.Entity<ItemCollection>().HasData(itemCollection);


            // Types
            ItemType[] types = new ItemType[2] {
                new ItemType { Name = "Self learning", ColorHex = "3d94db", Id = 1 },
                new ItemType { Name = "Work", ColorHex = "aa94db", Id = 2 }
            };
            
            Seeder<ItemType>(modelBuilder, types);


            // Tasks
            Item[] items = new Item[3] {
                new() { Id =  1,  Name = "Finish Todo", CreatedAt = DateTime.Now, Description = "Please", ItemCollectionId = 1 },
                new() { Id = 2, Name = "Add Opengl examples", CreatedAt = DateTime.Now, Description = "Please", ItemCollectionId = 1 },
                new() { Id = 3, Name = "Add triangle rendering to image", CreatedAt = DateTime.Now, Description = "Please", ItemCollectionId = 1 }
            };
            Seeder<Item>(modelBuilder, items);

            ItemsTypesJoin[] joins = new ItemsTypesJoin[3] {
                new() {ItemId = 1, ItemTypeId = 1},
                new() {ItemId = 2, ItemTypeId = 1},
                new() {ItemId = 1, ItemTypeId = 2}
            };
            Seeder<ItemsTypesJoin>(modelBuilder, joins);

        }

        private static void Seeder<T>(ModelBuilder modelBuilder, T[] arr) where T : class
        {
            foreach (T tt in arr)
            {
                modelBuilder.Entity<T>().HasData(tt);
            }
        }
    }
}
