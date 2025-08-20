using System;
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int? DeptId { get; set; }
    public int? ManagerId { get; set; }

}
public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }   
    public string Location { get; set; }
}
public class Program
{
    public static void Main(string[] args)
    {

    var employees = new List<Employee> {
    new Employee() { Id = 1, Name = "Asha", DeptId = 1, ManagerId = null },
    new Employee() { Id = 2, Name = "Vikram", DeptId = 1, ManagerId = 1 },
    new() { Id = 3, Name = "Neeraj", DeptId = 2, ManagerId = 1 },
    new() { Id = 4, Name = "Sara", DeptId = null, ManagerId = 2 },
};
    var departments = new List<Department> {
    new() { Id = 1, Name = "Engineering", Code="ENG", Location="BLR" },
    new() { Id = 2, Name = "HR", Code="HR", Location="PUN" },
    new() { Id = 3, Name = "Finance", Code="FIN", Location="BLR" }

};

    // NAME OF EMPLOYEES and DEPARTMENT name

        //var res = from e in employees
        //          join d in departments on e.Id equals d.Id
        //          select d.Name;
        //Console.WriteLine(res); 

        var res = employees.Join(
              departments,
              e => e.DeptId,
              d => d.Id,
              (e,d)=> new {Empname = e.Name, Deptname = d.Name}
            );


        foreach(var r in res)
        {
            Console.WriteLine(r.Empname + " " + r.Deptname);
        }

    }
}



