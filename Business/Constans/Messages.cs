﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";

        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";

        public static string ProductNameAlreadyExists = "Bu isimde bir ürün zaten bulunuyor";

        public static string CategoryLimitExceded = " Kategori limiti aşıldığı için yeni ürün eklenemiyor";
    }
}
