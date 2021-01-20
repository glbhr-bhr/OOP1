using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }

        //Kategori
        public int CategoryId { get; set; }

        //ürün ismi
        public string ProductName { get; set; }

        //birim fiyatı
        public double UnitPrice { get; set; }

        //stok adeti
        public int UnitInStock { get; set; }

    }
}
