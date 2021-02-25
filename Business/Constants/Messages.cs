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
        // degiskenlerin ismini buyuk yazdik. cunku public olan degiskenler PascalCase yazilir
    }
}
