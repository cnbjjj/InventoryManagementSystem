using InventoryManagementSystem.Products;

namespace InventoryManagementSystem.Coupons
{
    public class WinterFest : Coupon
    {
        private int _secret = 0;
        public int Secret { get => _secret; }
        public WinterFest(string code, ECategory category, double discount, DateTime expirydate, string description = "Winter Fest Coupon for All Products") : base(code, category, discount, expirydate, description)
        {
            // used for spacecial event later after the coupon is used
            _secret = new Random().Next(1000, 9999);
        }
    }
}