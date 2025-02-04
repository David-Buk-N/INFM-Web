﻿namespace INFM_Web.Models
{
    [Table("OrderStatus")]
    public class OrderStatus
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int StatusId { get; set; }
        [Required]
        [MaxLength(0)]
        public string? StatusName { get; set; }
    }
}
