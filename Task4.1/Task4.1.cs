class Program 
{
    static void Main(string[] aargs) 
    {
        var departments = new List<Department>()
        {
            new Department() {Id = 1, Name = "Программирование"},
            new Department() {Id = 2, Name = "Продажи"}
        };

        var employees = new List<Employee>()
        {
            new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
            new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
            new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
            new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
        };

        var joinedList = employees.Join(departments, 
            employee => employee.DepartmentId,
            department => department.Id,
            (employee, department) => 
            new
            {
                Name = employee.Name,
                Id = employee.Id,
                Department = department.Name
            });

        foreach (var employee in joinedList) 
        {
            Console.WriteLine(employee.Name + " работает в отделе - " + employee.Department);
        }
    }
}

internal class Employee
{
    public int DepartmentId { get; internal set; }
    public string Name { get; internal set; }
    public int Id { get; internal set; }
}

internal class Department
{
    public int Id { get; internal set; }
    public string Name { get; internal set; }
}