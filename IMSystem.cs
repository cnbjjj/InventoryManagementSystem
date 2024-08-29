using InventoryManagementSystem.Members;
using InventoryManagementSystem.Products;
using InventoryManagementSystem.Transactions;
namespace InventoryManagementSystem
{
    public class IMSystem
    {

        private List<IMember> members = new List<IMember>();
        private List<IProduct> products = new List<IProduct>();
        private List<Transaction> transactions = new List<Transaction>();

        public void AddMember(IMember member)
        {
            if (member == null)
            {
                Console.WriteLine("Member is null");
                return;
            }
            if (!members.Contains(member))
                members.Add(member);
            else
                UpdateMember(member);
        }

        public void UpdateMember(IMember member)
        {
            if (member != null && members.Contains(member))
            {
                members.Remove(member);
                members.Add(member);
            }
            else
                Console.WriteLine("Member not found");
        }

        public void DeleteMember(IMember member)
        {
            if (member != null)
                members.Remove(member);
        }

        public void DisplayMembers()
        {
            foreach (var member in members)
            {
                Console.WriteLine(member);
            }
        }

        public void AddProduct(IProduct product)
        {
            if (product == null)
            {
                Console.WriteLine("Product is null");
                return;
            }
            if (!products.Contains(product))
                products.Add(product);
            else
                UpdateProduct(product);
        }

        public void UpdateProduct(IProduct product)
        {
            if (product != null && products.Contains(product))
            {
                int index = products.IndexOf(product);
                products.Remove(product);
                products.Add(product);
                Console.WriteLine($"Product #{product.ID} {product.Name} updated");
            }
            else
                Console.WriteLine("Product not found");
        }

        public void DeleteProduct(IProduct product)
        {
            if (product != null)
                products.Remove(product);
        }

        public void DisplayProducts()
        {
            DisplayProducts<IProduct>();
        }

        public void DisplayProducts<T>()
        {
            foreach (var product in products)
            {
                if (product is T)
                {
                    Console.WriteLine(product);
                }
            }
        }

        public void AddTransaction(Transaction transaction)
        {
            if (transaction == null)
            {
                Console.WriteLine("Transaction is null");
                return;
            }
            if (!transactions.Contains(transaction))
                transactions.Add(transaction);
            else
                UpdateTransaction(transaction);
        }

        public void UpdateTransaction(Transaction transaction)
        {
            if (transaction != null && transactions.Contains(transaction))
            {
                transactions.Remove(transaction);
                transactions.Add(transaction);
            }
            else
                Console.WriteLine("Transaction not found");
        }

        public void DeleteTransaction(Transaction transaction)
        {
            if (transaction != null)
                transactions.Remove(transaction);
        }

        public void DisplayTransactions()
        {
            DisplayTransactions<IProduct>();
        }

        public void DisplayTransactions<T>()
        {
            foreach (var transaction in transactions)
            {
                if (transaction.Product is T)
                {
                    transaction.Display();
                }
            }
        }

    }
}