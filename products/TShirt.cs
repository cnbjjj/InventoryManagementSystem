namespace InventoryManagementSystem.Products
{
    public class TShirt : Product
    {
        public string Size { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }

        public TShirt(string name, int quantity, ECategory category, double price, string size, string color, string brand) : base(name, quantity, category, price)
        {
            Size = size;
            Color = color;
            Brand = brand;
        }
    }
}