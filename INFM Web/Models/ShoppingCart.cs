
namespace INFM_Web.Models
{
    [Table("ShoppingCart")]
    public class ShoppingCart
    {
        [Key]
        public int ShoppingCart_Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public bool IsDeleted { get; set; } = false;

        public ICollection<CartDetail> CartDetails { get; set; }
    }
}
