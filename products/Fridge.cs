namespace InventoryManagementSystem.Products
{
    public class Fridge : Product
    {
        public int Size { get; set; }
        public string Brand { get; set; }
        public int Capcity { get; set; }

        public Fridge(string name, int quantity, ECategory category, double price, int size, string brand, int capcity) : base(name, quantity, category, price)
        {
            Size = size;
            Brand = brand;
            Capcity = capcity;
        }
    }
}