﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project2BurgerMenu.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<Product> Proucts { get; set; }
    }
}