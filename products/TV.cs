namespace InventoryManagementSystem.Products
{
    public class TV : Product
    {
        public int Size { get; set; }
        public string Resolution { get; set; }
        public string Brand { get; set; }

        public TV(string name, int quantity, ECategory category, double price, int size, string resolution, string brand) : base(name, quantity, category, price)
        {
            Size = size;
            Resolution = resolution;
            Brand = brand;
        }
    }
}