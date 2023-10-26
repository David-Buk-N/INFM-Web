namespace INFM_Web.Repo
{
    public interface ICartRepository
    {
        Task<int> AddItem(int productId, int qty);
        Task<int> RemoveItem(int productId);
        Task<ShoppingCart> GetUserCart();
        Task<ShoppingCart> GetCart(string userId);
        Task<int> GetCartItemCount(string userId = "");
    }
}
