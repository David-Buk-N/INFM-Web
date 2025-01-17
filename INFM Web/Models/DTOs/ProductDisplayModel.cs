﻿namespace INFM_Web.Models.DTOs
{
    public class ProductDisplayModel
    {
        public IEnumerable<Product> products { get; set; }
        public IEnumerable<Category> categories { get; set; }
        public string STerm { get; set; } = "";
        public int CategoryId { get; set; } = 0;
    }
}
