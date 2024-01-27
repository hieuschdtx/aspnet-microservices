using Catalog.API.Entities;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new()
                {
                    id = "602d2149e773f2a3990b47f5",
                    name = "IPhone X",
                    summary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    image_file = "product-1.png",
                    price = 950.00M,
                    category = "Smart Phone"
                },
                new()
                {
                    id = "602d2149e773f2a3990b47f6",
                    name = "Samsung 10",
                    summary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    image_file = "product-2.png",
                    price = 840.00M,
                    category = "Smart Phone"
                },
                new()
                {
                    id = "602d2149e773f2a3990b47f7",
                    name = "Huawei Plus",
                    summary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    image_file = "product-3.png",
                    price = 650.00M,
                    category = "White Appliances"
                },
                new()
                {
                    id = "602d2149e773f2a3990b47f8",
                    name = "Xiaomi Mi 9",
                    summary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    image_file = "product-4.png",
                    price = 470.00M,
                    category = "White Appliances"
                },
                new()
                {
                    id = "602d2149e773f2a3990b47f9",
                    name = "HTC U11+ Plus",
                    summary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    image_file = "product-5.png",
                    price = 380.00M,
                    category = "Smart Phone"
                },
                new()
                {
                    id = "602d2149e773f2a3990b47fa",
                    name = "LG G7 ThinQ",
                    summary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    image_file = "product-6.png",
                    price = 240.00M,
                    category = "Home Kitchen"
                }
            };
        }
    }
}