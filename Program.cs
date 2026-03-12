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
        Item item1 = new Item("Phone", 800, 2);
        Console.WriteLine($"Item: {item1.Name}, Price: {item1.Price}, Quantity: {item1.Quantity}"); 
        Supplier supplier1 = new Supplier("TechSupply", "Paris", "0102030405");
        Console.WriteLine($"Supplier: {supplier1.Name}, City: {supplier1.City}, Phone: {supplier1.Phone}");
        Category category1 = new Category("Electronics", "Electronic devices"); 
        Category category2 = new Category("Books", "Books and literatures"); 
        Category category3 = new Category("Clothing", "Clothing and accessories");
        Console.WriteLine($"Category: {category1.Name}, Description: {category1.Description}");
        Console.WriteLine($"Category: {category2.Name}, Description: {category2.Description}");
        Console.WriteLine($"Category: {category3.Name}, Description: {category3.Description}");
        ProductId productId1=new ProductId(1,"Tablet",600);
        Console.WriteLine($"Product ID: {productId1.Id}, Name: {productId1.Name}, Price: {productId1.Price}");
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
    class Item
{
    private string name;
    private double price;
    private int quantity;
     
    public Item( string name,double price,int quantity)
    {
        this.name=name;
        this.price=price;
        this.quantity=quantity;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public double Price
    {
        get { return price; }
        set { price = value; }
    }
    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }
}
    class Supplier
{
    private string name;
    private string city;
    private string phone;
    public Supplier(string name,string city,string phone)
    {
        this.name=name;
        this.city=city;
        this.phone=phone;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string City
    {
        get { return city; }
        set { city = value; }
    }
    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }
}
    class Category
{
    private string name;
    private string description;
    public Category(string name,string description)
    {
        this.name=name;
        this.description=description;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Description
    {
        get { return description; }
        set { description = value; }
    }
}
    class ProductId
{
   private int id;
   private string name;
   private double price;
   public ProductId(int id,string name,double price) 
   {
       this.id = id;
       this.name = name;
       this.price = price;
   }
    public int Id {get;}
    public string Name {get;}
    public double Price {get;}
    
}