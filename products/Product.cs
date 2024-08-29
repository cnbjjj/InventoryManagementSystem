using InventoryManagementSystem.Common;

namespace InventoryManagementSystem.Products
{
    public abstract class Product : IProduct, IDisplay
    {
        private static int _ID = 0;
        private double _discount = 0;
        private int _quantity = 0;
        private double _price = 0;
        public int ID { get; }
        public string Name { get; set; }
        public int Quantity
        {
            get => _quantity;
            set
            {
                if (value < 0)
                    Console.WriteLine("Quantity cannot be less than 0");
                else
                    _quantity = value;
            }
        }
        public double Price
        {
            get => _price;
            set
            {
                if (value < 0)
                    Console.WriteLine("Price cannot be less than 0");
                else
                    _price = value;
            }
        }
        public double Discount
        {
            get => _discount;
            set
            {
                if (value < 0 || value > 1)
                    Console.WriteLine("Discount cannot be less than 0 or greater than 1");
                else
                    _discount = value;
            }
        }
        public ECategory Category { get; set; }

        protected static int GetID()
        {
            return ++_ID;
        }

        public Product(string name, int quantity, ECategory category, double price, double discount = 0)
        {
            ID = GetID();
            Name = name;
            Quantity = quantity;
            Category = category;
            Price = price;
            Discount = discount;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != this.GetType())
                return false;
            Product p = (Product)obj;
            return p.ID == this.ID;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(ID);
        }

        public override string ToString()
        {
            return $"Product: {this.GetType().Name}, ID: {ID}, Name: {Name}, Quantity: {Quantity}, Price: ${Price}, Discount: {Discount*100}% Category: {Category}";
        }

        public void Display()
        {
            Console.WriteLine(this);
        }
    }


}