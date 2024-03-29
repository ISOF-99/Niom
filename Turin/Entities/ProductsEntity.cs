﻿using System.ComponentModel.DataAnnotations;
using Turin.Entity;

namespace Turin.Entity
{
    internal class ProductsEntity
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public CategoryEntity Category { get; set; } = null!;
    }
}
