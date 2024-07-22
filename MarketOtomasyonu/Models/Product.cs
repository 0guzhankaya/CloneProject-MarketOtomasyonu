using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string QRCode { get; set; }
        public string Barcode { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string ProductName { get; set; }
        public int Kilogram { get; set; }
        public int Price { get; set; }
        public int Endorsement { get; set; }
    }
}
