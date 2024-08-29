using InventoryManagementSystem.Common;
namespace InventoryManagementSystem.Members
{
    public interface IMember: IDisplay
    {
        int ID { get; }
        string Name { get; set; }
        List<ICoupon> Coupons { get; }
    }
}