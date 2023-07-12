using StandardWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StandardWebApi.Repositories
{
    public class ProductRepository : IDataRepository<Product>
    {
        public Product Get(int id)
        {
            var product = new Product()
            {
                Id = 1,
                Description = "Pen"
            };
            return product;
        }

        public List<Product> Get()
        {
            var products = new List<Product>()
            {
                new Product{
                    Id = 1,
                    Description = "Pen"
                },
                new Product {
                    Id = 2,
                    Description = "Pencil"
                }
            };

            return products;
        }

        public int Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Product entity)
        {
            throw new NotImplementedException();
        }
    }
}