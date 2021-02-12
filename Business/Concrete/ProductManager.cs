using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        //Constructorin calismasi:  ProductManager newlendigi anda bir IProductDal nesnesinin referansini alir.
        // Bu referans adresi bizim olusturdugumuz _productDal nesnesine aktarilir.
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //is kodlari
            //veri is kodlarindan geciyorsa yani is kodlari calisiyorsa
            //artik veri erisimi cagirmamiz lazim.

            //InMemoryProductDal inMemoryProductDal = new InMemoryProductDal();
            //boyle yaparsak bizim is kodlarimizin tamami bellekle calisir. 
            //gercek bellek kullanimina gececegin zaman sistemde GetAll gibi binlerce operasyon var. 
            //bu yuzden sistemde yer alan butun "InMemoryProductDal inMemoryProductDal = new InMemoryProductDal();" leri degistirmek gerekir.
            //Bir is sinifi baska bir sinifi newlemez kuralina aykiri bir durum olusur. bunu bu yuzden kullanmiyoruz. 
            //Bunun yerine Injection yapiyoruz. IProductDal _productDal;

            // bundan sonra IProductDal daki GetAll u cagirip dondurebilirsin.

            return _productDal.GetAll();


        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p=>p.CategoryId==id);
        }

        public List<Product> GetAllByCategoryId()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetByUnitePrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }
    }
}
