﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string? Name { get; set; }

        //relation
        public List<Product>? Products { get; set; }
    }
}
