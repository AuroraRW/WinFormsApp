using System.Xml.Linq;

namespace LINQ2
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = Data.GetEmployees();
            List<Department> departmentList = Data.GetDepartments();
            // Sorting Operations OrderBy, OrderByDescending, ThenBy, ThenByDescending
            //Method Syntax
            //var results = employeeList.Join(departmentList, e => e.DepartmentId, d => d.Id,
            //    (emp, dept) => new
            //    {
            //        Id = emp.Id,
            //        FirstName = emp.FirstName,
            //        LastName = emp.LastName,
            //        AnnualSalary = emp.AnnualSalary,
            //        DepartmentId = emp.DepartmentId,
            //        DepartmentName = dept.LongName
            //    }).OrderBy(o => o.DepartmentId).ThenByDescending(o => o.AnnualSalary);

            //foreach (var item in results)
            //    Console.WriteLine($"First Name: {item.FirstName,-10} " +
            //                        $"Last Name: {item.LastName,-10} " +
            //                        $"Annual Salary: {item.AnnualSalary,10}\t" +
            //                        $"Department Name: {item.DepartmentName}");


            ////Query Syntax
            //var results = from emp in employeeList
            //              join dept in departmentList
            //              on emp.DepartmentId equals dept.Id
            //              orderby emp.DepartmentId, emp.AnnualSalary descending
            //              select new
            //              {
            //                  Id = emp.Id,
            //                  FirstName = emp.FirstName,
            //                  LastName = emp.LastName,
            //                  AnnualSalary = emp.AnnualSalary,
            //                  DepartmentId = emp.DepartmentId,
            //                  DepartmentName = dept.LongName
            //              };
            //foreach (var item in results)
            //    Console.WriteLine($"First Name: {item.FirstName,-10} Last Name: {item.LastName,-10} Annual Salary: {item.AnnualSalary,10}\tDepartment Name: {item.DepartmentName}");

            //Grouping Operators
            //GroupBy
            //Deferred Execution
            //var groupResult = from emp in employeeList
            //                  orderby emp.DepartmentId descending
            //                  group emp by emp.DepartmentId;
            //employeeList.Add(new Employee
            //{
            //    Id = 5,
            //    FirstName = "Sam",
            //    LastName = "Davis",
            //    AnnualSalary = 100000.20m,
            //    IsManager = true,
            //    DepartmentId = 2
            //});

            //foreach (var empGroup in groupResult)
            //{
            //    Console.WriteLine($"Department Id: {empGroup.Key}");

            //    foreach (Employee emp in empGroup)
            //    {
            //        Console.WriteLine($"\tEmployee Fullname: {emp.FirstName} {emp.LastName}");
            //    }

            //}

            //ToLookup Operator
            // Immediate Execution
            //var groupResult = employeeList.OrderByDescending(o => o.DepartmentId).ToLookup(e => e.DepartmentId);
            ////var groupResult = employeeList.ToLookup(e => e.DepartmentId);

            //employeeList.Add(new Employee
            //{
            //    Id = 5,
            //    FirstName = "Sam",
            //    LastName = "Davis",
            //    AnnualSalary = 100000.20m,
            //    IsManager = true,
            //    DepartmentId = 2
            //});

            //foreach (var empGroup in groupResult)
            //{
            //    Console.WriteLine($"Department Id: {empGroup.Key}");

            //    foreach (Employee emp in empGroup)
            //    {
            //        Console.WriteLine($"\tEmployee Fullname: {emp.FirstName} {emp.LastName}");
            //    }
            //}

            ////All, Any, Contains Quantifier Operators
            ////All and Any Operators
            //var annualSalaryCompare = 40000;

            //bool isTrueAll = employeeList.All(e => e.AnnualSalary > annualSalaryCompare);
            //if (isTrueAll)
            //{
            //    Console.WriteLine($"All employee annual salaries are above {annualSalaryCompare}");
            //}
            //else
            //{
            //    Console.WriteLine($"Not all employee annual salaries are above {annualSalaryCompare}");
            //}

            //bool isTrueAny = employeeList.Any(e => e.AnnualSalary > annualSalaryCompare);
            //if (isTrueAny)
            //{
            //    Console.WriteLine($"At least one employee has an annual salary above {annualSalaryCompare}");
            //}
            //else
            //{
            //    Console.WriteLine($"No employees have an annual salary above {annualSalaryCompare}");
            //}

            //Contains Operator
            //Compare the reference
            //var searchEmployee = new Employee
            //{
            //    Id = 3,
            //    FirstName = "Douglas",
            //    LastName = "Roberts",
            //    AnnualSalary = 40000.2m,
            //    IsManager = false,
            //    DepartmentId = 2
            //};

            //bool containsEmployee = employeeList.Contains(searchEmployee);

            //if (containsEmployee)
            //{
            //    Console.WriteLine($"An employee record for {searchEmployee.FirstName} {searchEmployee.LastName} was found");
            //}
            //else
            //{
            //    Console.WriteLine($"An employee record for {searchEmployee.FirstName} {searchEmployee.LastName} was not found");
            //}

            ////ElementAt, ElementAtOrDefault, First, FirstOrDefault, Last, LastOrDefault, Single and SingleOrDefault Element Operators
            ////ElementAt (out of range, throw error)
            ////ElementAtOrDefault (out of range, return null)
            //var emp = employeeList.ElementAtOrDefault(2);

            //if (emp != null)
            //{
            //    Console.WriteLine($"{emp.Id,-5} {emp.FirstName,-10} {emp.LastName,-10}");
            //}
            //else
            //{
            //    Console.WriteLine("This employee record does not exist within the collection");
            //}

            ////First, FirstOrDefault, Last, LastOrDefault Operators
            //List<int> integerList = new List<int> { 3, 13, 23, 17, 26, 87, 38 };

            ////int result = integerList.First(i => i % 2 == 0);
            ////int result = integerList.FirstOrDefault(i => i % 2 == 0);
            //int result = integerList.LastOrDefault(i => i % 2 == 0);

            //// If no element, return 0
            //if (result != 0)
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("There are no even numbers in the collection");
            //}


            //List<int> integerList = new List<int> {0, 3, 13, 23, 17, 26, 87, 38 };

            ////int result = integerList.First(i => i % 2 == 0);
            //int result = integerList.FirstOrDefault(i => i % 2 == 0);
            ////int result = integerList.LastOrDefault(i => i % 2 == 0);

            //// If no element, return 0
            //if (result == 0 && !integerList.Contains(0))
            //{
            //    Console.WriteLine("There are no even numbers in the collection");

            //}
            //else
            //{
            //    Console.WriteLine(result);
            //}


            //var emp = employeeList.FirstOrDefault(emp=>emp.DepartmentId==2);
            //if (emp != null) 
            //{
            //    Console.WriteLine($"{emp.Id,-5} {emp.FirstName,-10} {emp.LastName,-10}");
            //}
            //else
            //{
            //    Console.WriteLine("No employee in department 2");
            //}


            ////Single, SingleOrDefault Operators

            ////SingleOrDefault: 
            ////If exactly one element satisfies the condition, it returns that element.
            ////If no elements satisfy the condition, it returns the default value(null for reference types).
            ////If more than one element satisfies the condition, it throws an InvalidOperationException.


            //var emp = employeeList.SingleOrDefault(e => e.DepartmentId == 3);

            //if (emp != null)
            //{
            //    Console.WriteLine($"{emp.Id,-5} {emp.FirstName,-10} {emp.LastName,-10}");
            //}
            //else
            //{
            //    Console.WriteLine("This employee does not exist within the collection");
            //}

        }
    }
}

