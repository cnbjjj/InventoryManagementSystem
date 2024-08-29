using InventoryManagementSystem.Products;

namespace InventoryManagementSystem.Coupons
{
    public class BlackFriday : Coupon
    {
        public BlackFriday(string code, ECategory category, double discount, DateTime expirydate, string description = "No description") : base(code, category, discount, expirydate, description)
        {
        }

        public void CombineCyberMonday(ICoupon coupon)
        {
            // The ability to combine BlackFriday and CyberMonday coupons
        }
    }
}