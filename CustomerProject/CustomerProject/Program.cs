using System;
using System.Collections.Generic;
using System.Linq;


    
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public string ProductName { get; set; }
        public decimal Amount { get; set; }
    }

public class items
{
     
    public int UserId { get; set; } 
    public int itemid {  get; set; }    
    public string ProductName { get; set; }
    public decimal Amount { get; set; } 
}

   
    public class ReportClass
    {
        public string CustomerName { get; set; }
        public decimal TotalOrderAmount { get; set; }
        public List<OrderReport> OrderDetails { get; set; }
    }

    public class OrderReport
    {
        public string ProductName { get; set; }
        public decimal Amount { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
          
            var users = new List<User>
            {
                new User { UserId = 1, Name = "Alice" },
                new User { UserId = 2, Name = "Bob" },
                new User { UserId = 3, Name = "Charlie" }
            };

          
            var orders = new List<Order>
            {
                new Order { OrderId = 101, UserId = 1, ProductName = "Laptop", Amount = 50000 },
                new Order { OrderId = 102, UserId = 1, ProductName = "Mouse", Amount = 1000 },
                new Order { OrderId = 103, UserId = 2, ProductName = "Keyboard", Amount = 1500 },
                new Order { OrderId = 104, UserId = 1, ProductName = "Monitor", Amount = 20000 }
            };

       
            var customerReports = orders
                .GroupBy(o => o.UserId)
                .Join(users,
                      g => g.Key,
                      u => u.UserId,
                      (g, u) => new ReportClass
                      {
                          CustomerName = u.Name,
                          TotalOrderAmount = g.Sum(o => o.Amount),
                          OrderDetails = g.Select(o => new OrderReport
                          {
                              ProductName = o.ProductName,
                              Amount = o.Amount
                          }).ToList()
                      })
                .ToList();

           
        //Printing
            foreach (var report in customerReports)
            {
                Console.WriteLine($"Customer: {report.CustomerName}, Total Order Amount: {report.TotalOrderAmount}");

                foreach (var order in report.OrderDetails)
                {
                    Console.WriteLine($"\tProduct: {order.ProductName}, Amount: {order.Amount}");
                }
            }
        }
    }

