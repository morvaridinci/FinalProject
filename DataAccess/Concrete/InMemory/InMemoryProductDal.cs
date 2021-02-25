using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
            //veri sanki bir veritabanindan geliyormus gibi biz simule ettik
            _products = new List<Product> {
                new Product{ProductId=1, CategoryId=1, ProductName= "Bardak", UnitPrice=15, UnitsInStock=15},
                new Product{ProductId=2, CategoryId=1, ProductName= "Kamera", UnitPrice=500, UnitsInStock=3},
                new Product{ProductId=3, CategoryId=2, ProductName= "Telefon", UnitPrice=1500, UnitsInStock=2},
                new Product{ProductId=4, CategoryId=2, ProductName= "Fare", UnitPrice=85, UnitsInStock=1}
            };
        }
        
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            // _products.Remove(product); ile asla veriyi silemeyiz (normalde listeden silebiliyoruz) 
            //referans uzerinden calistigi icin. 
            //biz urunleri silerken onun primaryKey ini kullanırız 
            //çünkü onu diğer urunlerden ayrıran şey primary keydır
            //burada karşımıza LINQ diye bir sistem çıkıyor
            //LINQ - Lenguage integrated query

            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
            //SingleOrDefault tek bir eleman bulmaya yarar. 
            //Products i tek tek dolasmaya yarar.
            //foreachin gibi ama tek urun buluyor
            // p tek tek dolasirken verdigin takma isim => dan sonrasina sart yazilir.

            /*
             foreach(var p in _products)
            {
               if(product.ProductId== p.ProductId)
               {
                 productToDelete = p;
               }
            }
             */

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

        public List<Product> GetAllByCategory(int categoryId)
        {
            // where icinde bulunan sarti saglayan butun elemanlari yeni bir liste yapar ve onu dondurur.
            // SQL deki gibi
            return _products.Where(p => p.CategoryId== categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //Gonderdigim urun Id sine sahip olan listedeki urunu bul.

            Product productToUpdate      =  _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName  =  product.ProductName;
            productToUpdate.CategoryId   =  product.CategoryId;
            productToUpdate.UnitPrice    =  product.UnitPrice;
            productToUpdate.UnitsInStock =  product.UnitsInStock;

            // bunlari bizim icin yapar entity framework, hibernate gibi teknolojilerle yapariz
        }
    }
}
