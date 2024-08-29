using InventoryManagementSystem.Common;
using InventoryManagementSystem.Members;
using InventoryManagementSystem.Products;

namespace InventoryManagementSystem.Transactions
{
    public class Transaction: IDisplay
    {
        public enum EStatus
        {
            PendingPayment,
            PaymentComplete,
            Dispatched,
            Delivered,
            Cancelled,
            Refunded,
            Returned
        };

        private static int _ID = 0;
        public int ID { get; }

        private IMember _member;
        public IMember Member { get => _member; set => _member = value; }

        private IProduct _product;
        public IProduct Product { get; set; }

        private ICoupon _coupon;
        public ICoupon Coupon { get; set; }

        private EStatus _status;
        public EStatus Status { get; set; }

        private int _quantity;
        public int Quantity { get; set; } = 0;

        private DateTime _date;
        public DateTime Date { get => _date; }

        public Transaction(IMember member, IProduct product, int quantity, ICoupon coupon = null, EStatus status = EStatus.PendingPayment)
        {
            ID = ++_ID;
            Member = member;
            Product = product;
            Quantity = quantity;
            Coupon = coupon;
            _status = status;
            _date = DateTime.Now;
        }

        public double CalculateTotal()
        {
            double total = 0;
            double price = Product.Price * (1 - Product.Discount) * Quantity;
            if (Coupon != null && Coupon.IsValid(Product))
            {
                total = price * (1 - Coupon.Discount);
                Coupon.Use();
            }
            else
                total = price;
            return total;
        }

        public void ApplyCoupon(ICoupon coupon)
        {
            if (coupon != null && coupon.IsValid(Product)){
                Coupon = coupon;
                Console.WriteLine($"Coupon (#{Coupon.ID} {Coupon.Code + "-" + (Coupon.Discount*100)}%) applied to Transaction #{ID} successfully");
            }
            else
                Console.WriteLine("Coupon not applicable on this product");
        }

        public void UpdateStatus(EStatus status)
        {
            Status = status;
            Console.WriteLine($"Transaction {ID} status updated to {status}");
        }

        public override string ToString()
        {
            return $"\n------------------------------Transaction ID: {ID}------------------------------ \n"+
            $"Member: #{Member.ID + "-" + Member.Name} \n"+
            $"Product: {Product.Name}{(Product.Discount>0?$"(Discount:{Product.Discount*100}%)":"")} \n"+
            $"Quantity: {Quantity} \n"+
            $"Date: {Date} \n"+
            $"Coupon: (#{Coupon.ID} {Coupon.Code + "-" + (Coupon.Discount*100)}%) {(Coupon.IsValid(Product)?"is Valid":"is not vaild for the product")} \n"+
            $"Total: ${CalculateTotal()} \n"+
            $"Status: {Status}";
        }

        public void Display()
        {
            Console.WriteLine(this);
        }
    }
}