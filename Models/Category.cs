﻿namespace ClothingStore.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string? Description { get; set; } 
        public List<Sneakers>? Sneakers { get; set; }

    }
}
