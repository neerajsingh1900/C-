using System;
using System;
using System.Collections.Generic;

public class Employee
{
    
    public int Id { get; set; }

    public string Name { get; set; } 

    public string Job { get; set; } 

    public string Location { get; set; }

    public decimal Salary { get; set; }

    public override string ToString() => $"{Id}: {Name} ({Job}) - {Location} - {Salary:C}";
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
{
    new Employee { Id = 1, Name = "Neeraj", Job = "Dev",    Location = "Delhi",  Salary = 70000m },
    new Employee { Id = 2, Name = "Asha",   Job = "QA",     Location = "Noida",  Salary = 45000m },
    new Employee { Id = 3, Name = "Rahul",  Job = "Dev",    Location = "Delhi",  Salary = 72000m },
    new Employee { Id = 4, Name = "Priya",  Job = "DevOps", Location = "Gurgaon",Salary = 80000m },
    new Employee { Id = 5, Name = "Anil",   Job = "QA",     Location = "Noida",  Salary = 47000m }
};

        IEnumerable<IGrouping<string,Employee>> groupbyjob = employees.GroupBy(e => e.Job);


        //foreach(IGrouping<string, Employee> grp in groupbyjob)
        //{

        //    Console.WriteLine($"{grp.Key}" + " " + grp.Count());

        //    foreach (Employee emp in grp)
        //    {
        //        Console.WriteLine(emp.Name);
        //    }

        //}

        var ll = employees.GroupBy(i => i.Job)
                            .Select(j => new 
                                {
                                    job = j.Key,
                                    // values are directly j
                                    Count = j.Count(),
                                    Employeess = j.ToList(),
                                    TotalSal = j.Sum(k => k.Salary)
                                }
                              ).ToList();


        //foreach(var jg in  ll)
        //{
        //    Console.WriteLine($"{jg.job}: Count={jg.Count}, TotalSalary={jg.TotalSal:C}" + " " + jg.Employeess[0]);
        //}
   

        //LOOK UP
        ILookup<string, Employee> lookupByJob = employees.ToLookup(m => m.Job);
   
        foreach(var jg in lookupByJob["Dev"])
        {
            Console.WriteLine(jg.Name);
        }
    
    }



}


