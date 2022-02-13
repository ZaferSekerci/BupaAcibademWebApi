

using System;
using System.Collections.Generic;

namespace BupaAcibademWebApi.Models
{
    public partial class Product
    {
        public Product()
        {
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int? Price { get; set; }


    }
}