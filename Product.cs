using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceListGenerator
{
    public class Product
    {
        public int id { get; set; }
        public string title{ get; set; }
        public int price { get; set; }
        public string currency { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public int rating { get; set; }
    }
}
