using InventoryManagementSystem.Common;

namespace InventoryManagementSystem.Members
{
    public class Member : IMember
    {
        private static int _ID = 0;
        public int ID { get; }

        private List<ICoupon> _coupons = new List<ICoupon>();
        public string Name { get; set; }
        public List<ICoupon> Coupons { get=>_coupons; }

        public Member(string name)
        {
            ID = ++_ID;
            Name = name;
        }

        public void AddCoupon(ICoupon coupon)
        {
            if (coupon == null || _coupons.Contains(coupon))
            {
                Console.WriteLine("Coupon is null or already exists");
                return;
            }
            _coupons.Add(coupon);
        }

        public void RemoveCoupon(ICoupon coupon)
        {
            _coupons.Remove(coupon);
        }

        public void DisplayCoupons()
        {
            foreach (ICoupon coupon in _coupons)
            {
                Console.WriteLine(coupon);
            }
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Member m = (Member)obj;
            return ID == m.ID && Name == m.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ID, Name);
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Coupons: {_coupons.Count}";
        }

        public void Display()
        {
            Console.WriteLine(this);
        }
    }
}