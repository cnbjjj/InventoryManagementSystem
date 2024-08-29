using InventoryManagementSystem.Products;

namespace InventoryManagementSystem
{
    public interface ICoupon
    {
        int ID { get; }
        string Code { get; set; }
        double Discount { get; set; }
        ECategory Category { get; set; }
        DateTime ExpiryDate { get; set; }
        bool IsUsed { get; set; }
        void Use() => IsUsed = true;
        bool IsValid(IProduct product);
    }
}