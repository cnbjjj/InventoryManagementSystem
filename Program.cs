using InventoryManagementSystem.Coupons;
using InventoryManagementSystem.Members;
using InventoryManagementSystem.Products;
using InventoryManagementSystem.Transactions;

namespace InventoryManagementSystem
{
    public class Program
    {
        public static void Spliter(string text)
        {
            Console.WriteLine("\n\n=============================================================================");
            Console.WriteLine("");
            Console.WriteLine("" + text);
            Console.WriteLine("");
            Console.WriteLine("=============================================================================");
        }
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Inventory Management System");

            IMSystem ims = new IMSystem();

            Spliter("Add Members");
            Member m1 = new Member("John");
            Member m2 = new Member("Jane");
            Member m3 = new Member("Jack");
            ims.AddMember(m1);
            ims.AddMember(m2);
            ims.AddMember(m3);
            ims.DisplayMembers();

            Spliter("Add Coupons to Members");
            WinterFest wf1 = new WinterFest("WF1", ECategory.All, 0.1, new DateTime(2023, 12, 25));
            BlackFriday bf1 = new BlackFriday("BF1", ECategory.Electronics, 0.1, new DateTime(2025, 11, 25), "Black Friday's Coupon for Electronics");
            BlackFriday bf2 = new BlackFriday("BF2", ECategory.Clothing, 0.2, new DateTime(2025, 11, 25), "Black Friday's Coupon for Clothing");
            BlackFriday bf3 = new BlackFriday("BF3", ECategory.Groceries, 0.3, new DateTime(2022, 11, 25), "Black Friday's Coupon for Groceries");
            m1.AddCoupon(wf1);
            m1.AddCoupon(bf1);
            m2.AddCoupon(bf2);
            m3.AddCoupon(bf3);
            m1.DisplayCoupons();
            m2.DisplayCoupons();
            m3.DisplayCoupons();

            Spliter("After Update Members' Coupons");
            ims.DisplayMembers();

            Spliter("Add Products");
            TV tv1 = new TV("Samsung X100", 100, ECategory.Electronics, 1500, 100, "4K", "Samsung");
            TV tv2 = new TV("Sony F60", 150, ECategory.Electronics, 2000, 200, "4K", "Sony");
            TV tv3 = new TV("LG C75", 200, ECategory.Groceries, 2500, 150, "4K", "LG");
            ims.AddProduct(tv1);
            ims.AddProduct(tv2);
            ims.AddProduct(tv3);

            Milk milk1 = new Milk("Milk1", 100, ECategory.Groceries, 2, "Brand1", "Type1", "2022-12-31");
            Milk milk2 = new Milk("Milk2", 200, ECategory.Groceries, 3, "Brand2", "Type2", "2022-12-31");
            Milk milk3 = new Milk("Milk3", 300, ECategory.Groceries, 4, "Brand3", "Type3", "2022-12-31");
            ims.AddProduct(milk1);
            ims.AddProduct(milk2);
            ims.AddProduct(milk3);

            TShirt shirt1 = new TShirt("Shirt1", 1000, ECategory.Clothing, 10, "Brand1", "Type1", "M");
            TShirt shirt2 = new TShirt("Shirt2", 2000, ECategory.Clothing, 20, "Brand2", "Type2", "L");
            TShirt shirt3 = new TShirt("Shirt3", 3000, ECategory.Clothing, 30, "Brand3", "Type3", "XL");
            ims.AddProduct(shirt1);
            ims.AddProduct(shirt2);
            ims.AddProduct(shirt3);

            Fridge fridge1 = new Fridge("Fridge1", 100, ECategory.Electronics, 1000, 100, "Samsung", 200);
            Fridge fridge2 = new Fridge("Fridge2", 200, ECategory.Electronics, 2000, 200, "LG", 150);
            Fridge fridge3 = new Fridge("Fridge3", 300, ECategory.Electronics, 3000, 300, "Sony", 300);
            ims.AddProduct(fridge1);
            ims.AddProduct(fridge2);
            ims.AddProduct(fridge3);

            ims.DisplayProducts();

            Spliter("Update Products");
            tv1.Quantity = 10;
            tv1.Discount = 0.1;
            tv2.Price = 5000;
            tv2.Discount = 0.2;
            tv3.Category = ECategory.Electronics;
            ims.UpdateProduct(tv1);
            ims.UpdateProduct(tv2);
            ims.UpdateProduct(tv3);

            fridge1.Brand = "Test Brand";
            fridge2.Price = 5000;
            fridge2.Discount = 0.2;
            fridge3.Quantity = 500;
            ims.UpdateProduct(fridge1);
            ims.UpdateProduct(fridge2);
            ims.UpdateProduct(fridge3);

            milk1.Brand = "Test Brand";
            milk2.Discount = 0.2;
            milk3.Quantity = 500;
            ims.UpdateProduct(milk1);
            ims.UpdateProduct(milk2);
            ims.UpdateProduct(milk3);

            Spliter("Products After Update");
            ims.DisplayProducts();

            Spliter("Add Transactions");
            Transaction t1 = new Transaction(m1, tv1, 1, m1.Coupons[0]);
            Transaction t2 = new Transaction(m2, tv2, 2, m2.Coupons[0]);
            Transaction t3 = new Transaction(m3, tv3, 1, m3.Coupons[0]);
            Transaction t4 = new Transaction(m1, fridge1, 1, m1.Coupons[1]);
            ims.AddTransaction(t1);
            ims.AddTransaction(t2);
            ims.AddTransaction(t3);
            ims.AddTransaction(t4);
            ims.DisplayTransactions();

            Spliter("Update Transactions");
            // Update transactions
            t3.UpdateStatus(Transaction.EStatus.PaymentComplete);
            t2.UpdateStatus(Transaction.EStatus.Dispatched);
            t1.UpdateStatus(Transaction.EStatus.Delivered);

            BlackFriday bf4 = new BlackFriday("BF4", ECategory.Electronics, 0.2, new DateTime(2025, 11, 25), "Black Friday's Coupon for Clothing");
            t4.ApplyCoupon(bf4);

            Spliter("Display Transactions");
            ims.DisplayTransactions();

        }
    }
}
