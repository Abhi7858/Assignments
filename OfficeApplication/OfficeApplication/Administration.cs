using System;

namespace OfficeApplication
{
    public class Administration : Department, IEmployeeManagementService
    {
        public EmployeeEntities1 Context = new EmployeeEntities1();
        public void AddEmployee(Employee employee)
        {
            Context.Employees.Add(employee);
            Context.SaveChanges();
            Console.WriteLine("Employee Added Successfully...");
        }

        public void RemoveEmployee(int employeeId)
        {
            var employee = Context.Employees.Find(employeeId);
            if (employee != null)
            {
                Context.Employees.Remove(employee);
                Context.SaveChanges();
                Console.WriteLine("Employee Removed SuccessFully....");
            }

        }

        public void UpdateEmployee(int employeeId)
        {
            var employee = Context.Employees.Find(employeeId);
            if (employee != null)
            {
                Console.Write("Update Name of {0}: ", employee.EmployeeName);
                employee.EmployeeName = Console.ReadLine();
                Console.Write("Update Department Id of {0}: ", employee.EmployeeName);
                employee.DepartmentId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Update Adress of {0}: ", employee.EmployeeName);
                employee.EmployeeAddress = Console.ReadLine();
                Context.SaveChanges();
            }
        }
    }
}
