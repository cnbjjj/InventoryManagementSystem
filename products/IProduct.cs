namespace InventoryManagementSystem.Products
{
    public enum ECategory
    {
        All,
        Electronics,
        Clothing,
        Groceries,
        Furniture
    }
    public interface IProduct
    {
        int ID { get; }
        string Name { get; set; }
        int Quantity { get; set; }
        double Price { get; set; }
        double Discount { get; set; }
        ECategory Category { get; set; }
    }
}