using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsCatalog_M_20.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Producer { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Measures { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set;}
    }
}