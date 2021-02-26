using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //burasi sabitler icin oldugundan iki saat newlememek icin static verdik. 
        //Uygulama hayati boyunca tek instance oluyor
        //yani staticler newlenmeeez! 
        public static string ProductAdded = "Urun eklendi";
        // bunu kullanabilmek icin static yaptik.
        public static string ProductNameInvalid = "Urun ismi gecersiz";
        public static string MaintenanceTime = "Sistem bakimda.";
        public static string ProductsListed="Urunler listelendi.";
        internal static string ProductCountOfCategoryError="Bir kategoride en fazla 10 urun olabilir.";
        internal static string ProductNameAlreadyExists="Bu isimde baska bir urun var.";
        internal static string CategoryLimitExceded="Kategori limiti asildigi icin yeni urun eklenemiyor.";
        // degiskenlerin ismini buyuk yazdik. cunku public olan degiskenler PascalCase yazilir
    }
}
