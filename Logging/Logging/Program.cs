using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

class Customer
{
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
    public string Username { get; set; }
    public string Address { get; set; }
}

class Order
{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public string ProductName { get; set; }
    public decimal Amount { get; set; }
}

class OrderReport
{
    public string ProductName { get; set; }
    public decimal Amount { get; set; }
}

class Report
{
    public string CustomerName { get; set; }
    public decimal TotalAmount { get; set; }
    public List<OrderReport> OrderDetails { get; set; }
}

class Logger
{
    private static string inputs = "[]";  
    public static void LogInput(List<Customer> customers)
    {
        inputs = JsonSerializer.Serialize(customers);
    }

    public static void LogError(Exception ex)
    {
        var deserialized = JsonSerializer.Deserialize<List<Customer>>(inputs);

        Console.WriteLine($"\n Exception: {ex.Message}");
       

        foreach (var c in deserialized)
        {
            Console.WriteLine($"ID: {c.CustomerId}, Name: {c.CustomerName}, Username: {c.Username}, Address: {c.Address}");
        }
    }
}

class Program
{
    static void Main()
    {
        List<Customer> allCustomers = new List<Customer>();

        try
        {
          
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine($"\n Enter details for Customer");

                Console.Write("Enter Customer Name: ");
                string custName = Console.ReadLine();

                Console.Write("Enter Username: ");
                string username = Console.ReadLine();

                Console.Write("Enter Address: ");
                string address = Console.ReadLine();

                var currentCustomer = new Customer
                {
                    CustomerId = i,
                    CustomerName = custName,
                    Username = username,
                    Address = address
                };

                allCustomers.Add(currentCustomer);

             
                Logger.LogInput(allCustomers);

                
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(address))
                {
                    throw new ArgumentException(" Username and Address cannot be empty.");
                }
            }

            // -------- Orders --------
            List<Order> orders = new List<Order>
            {
                new Order { OrderId = 1, CustomerId = 1, ProductName = "Laptop", Amount = 1200 },
                new Order { OrderId = 2, CustomerId = 1, ProductName = "Mouse", Amount = 25 },
                new Order { OrderId = 3, CustomerId = 2, ProductName = "Keyboard", Amount = 45 }
            };

            var report = orders
                .GroupBy(o => o.CustomerId)
                .Select(g => new Report
                {
                    CustomerName = $"Customer {g.Key}",
                    TotalAmount = g.Sum(x => x.Amount),
                    OrderDetails = g.Select(o => new OrderReport
                    {
                        ProductName = o.ProductName,
                        Amount = o.Amount
                    }).ToList()
                })
                .ToList();

            Console.WriteLine("\n Program completed successfully.");
        }
        catch (Exception ex)
        {
            Logger.LogError(ex);
        }
    }
}
