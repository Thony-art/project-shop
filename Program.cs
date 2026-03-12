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
       
    }

}