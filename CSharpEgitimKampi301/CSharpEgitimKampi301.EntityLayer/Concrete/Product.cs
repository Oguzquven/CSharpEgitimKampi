﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public int ProductPrice { get; set; }
        public string productDescription { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public List<Order>Orders { get; set; }

    }
}
