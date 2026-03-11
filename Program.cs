using System.Security.Cryptography;

namespace project_shop;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Product p1 = new Product("Laptop", 1200);
        Customer c1 = new Customer("Alice","Martin","alice@email.com");
        Order o1 = new Order(1001, 350, true);
        Console.WriteLine($"Product: {p1.GetName()}, Price: {p1.GetPrice()}");
        Console.WriteLine($"Customer: {c1.GetFirstname()} {c1.GetLastname()}, Email: {c1.GetEmail()}");
        Console.WriteLine($"Order Number: {o1.GetOrderNumber()}, Total Amount: {o1.GetTotalAmount()}, Is Paid: {o1.IsPaid()}");
       
    }

}
 
    class Product
    {
        private string name;
        private double price;

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public string GetName()
        {
            return name;
         }
         public void SetName(string name)
         {
            this.name = name;
         }

          public double GetPrice()
        {
            return price;
        }
          public void SetPrice(double price)
        {
            this.price = price;
        }

 }
    class Customer
{
        private string firstname;
        private string lastname;
        private string email;

        public Customer(string firstname, string lastname, string email)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
        }
        public string GetFirstname()
        {
            return firstname;
        }
        public void SetFirstname(string firstname)
        {
            this.firstname = firstname;
        }
        public string GetLastname()
        {
            return lastname;
        }
        public void SetLastname(string lastname)
        {
            this.lastname = lastname;
        }
        public string GetEmail()
        {
            return email;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }

}
    class Order
{
    private int orderNumber;
    private double totalAmount;
    private bool isPaid;

    public Order(int orderNumber, double totalAmount, bool isPaid)
    {
        this.orderNumber = orderNumber;
        this.totalAmount = totalAmount;
        this.isPaid = isPaid;
    }
    public int GetOrderNumber()
    {
        return orderNumber;
    }
    public void SetOrderNumber(int orderNumber)
    {
        this.orderNumber = orderNumber;
    }
    public double GetTotalAmount()
    {
        return totalAmount;
    }
    public void SetTotalAmount(double totalAmount)
    {
        this.totalAmount = totalAmount;
    }
    public bool IsPaid()
    {
        return isPaid;
    }
    public void SetIsPaid(bool isPaid)
    {
        this.isPaid = isPaid;
    }
}