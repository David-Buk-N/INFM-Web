namespace INFM_Web.Models
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Product_Id { get; set; }
        public Product Product { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int UnitPrice { get; set; }
        [Required]
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
