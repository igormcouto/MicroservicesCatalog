using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productColletion)
        {
            bool existProduct = productColletion.Find(p => true).Any();
            if (!existProduct)
                productColletion.InsertManyAsync(GetMyProducts());
        }

        private static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>()
            {   new Product()
                {
                    Id = "1",
                    Name = "Iphone X",
                    Description = "Teste 1",
                    Image = "iphone.png",
                    Price = 950.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id = "2",
                    Name = "Samsung S20",
                    Description = "Teste 2",
                    Image = "samsung.png",
                    Price = 750.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id = "3",
                    Name = "TV 55 Samsung",
                    Description = "Teste 3",
                    Image = "tvsamsung.png",
                    Price = 3550.00M,
                    Category = "Smart TV"
                },
                new Product()
                {
                    Id = "4",
                    Name = "Notebook Acer",
                    Description = "Teste 4",
                    Image = "note.png",
                    Price = 1000.00M,
                    Category = "Notebook"
                }
            };
        }
    }
}
