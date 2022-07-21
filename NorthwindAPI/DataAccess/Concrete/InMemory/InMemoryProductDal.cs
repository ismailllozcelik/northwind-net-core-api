using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>()
            {
                new Product(){ProductId = 1, CategoryId=1, ProductName = "Cüzdan", UnitPrice=10, UnitsInStock=120},
                new Product(){ProductId = 2, CategoryId=2, ProductName = "Telefon", UnitPrice=2000, UnitsInStock=10},
                new Product(){ProductId = 3, CategoryId=1, ProductName = "Kemer", UnitPrice=50, UnitsInStock=70},
                new Product(){ProductId = 4, CategoryId=3, ProductName = "Sakız", UnitPrice=3, UnitsInStock=1000},
                new Product(){ProductId = 5, CategoryId=2, ProductName = "Bilgisayar", UnitPrice=6800, UnitsInStock=5},

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ - Language Integrated Query
            //Lambda
            Product deleteProduct = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(deleteProduct);
        }

        public Product Get(int id)
        {
            return _products.SingleOrDefault(p => p.ProductId == id);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsById(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Console.WriteLine("You can do it :)");
        }
    }
}
