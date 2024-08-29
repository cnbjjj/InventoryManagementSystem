namespace InventoryManagementSystem.Products
{
    public class Milk : Product
    {
        public string Brand { get; set; }
        public string Type { get; set; }
        public string ExpiryDate { get; set; }

        public Milk(string name, int quantity, ECategory category, double price, string brand, string type, string expiryDate) : base(name, quantity, category, price)
        {
            Brand = brand;
            Type = type;
            ExpiryDate = expiryDate;
        }
    }
}