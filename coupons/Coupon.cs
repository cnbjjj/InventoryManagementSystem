
using InventoryManagementSystem.Common;
using InventoryManagementSystem.Products;

namespace InventoryManagementSystem.Coupons
{
    public abstract class Coupon : ICoupon, IDisplay
    {
        private static int _ID = 0;
        public int ID { get; }
        public double Discount { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public ECategory Category { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsUsed { get; set; }

        public Coupon(string code, ECategory category, double discount, DateTime expirydate, string description = "No description")
        {
            ID = _ID++;
            Code = code;
            Category = category;
            Discount = discount;
            ExpiryDate = expirydate;
            Description = description;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Code: {Code}, Category: {Category}, Discount: {Discount*100}%, Expiry Date: {ExpiryDate}, Description: {Description}";
        }

        public bool IsValid(IProduct product)
        {
            return !IsUsed && product.Category == Category && ExpiryDate > DateTime.Now;
        }

        public void Display()
        {
            Console.WriteLine(this);
        }
    }
}