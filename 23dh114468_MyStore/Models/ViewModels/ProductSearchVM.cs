﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _23dh114468_MyStore.Models.ViewModels
{
    public class ProductSearchVM
    {
        public string SearchTerm {  get; set; }
        public List<Product> Products { get; set; }
    }
}