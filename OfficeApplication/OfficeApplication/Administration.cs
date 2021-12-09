using System;

namespace OfficeApplication
{
    public class Administration : Department, IEmployeeManagementService
    {
        public EmployeeEntities Context = new EmployeeEntities();
        public void AddEmployee(TblEmployee employee)
        {
            Context.TblEmployees.Add(employee);
            Context.SaveChanges();
        }

        public void RemoveEmployee(int removeId)
        {
            var Employee = Context.TblEmployees.Find(removeId);
            if (Employee != null)
            {
                Context.TblEmployees.Remove(Employee);
                Context.SaveChanges();
                Console.WriteLine("Employee Removed SuccessFully....");
            }

        }

        public void UpdateEmployee(int updateId)
        {
            var Employee = Context.TblEmployees.Find(updateId);
            if (Employee != null)
            {
                Console.Write("Update Name of {0}: ", Employee.EmployeeName);
                Employee.EmployeeName = Console.ReadLine();
                Console.Write("Update Department Name of {0}: ", Employee.EmployeeName);
                Employee.DepartmentName = Console.ReadLine();
                Console.Write("Update Adress of {0}: ", Employee.EmployeeName);
                Employee.EmployeeAddress = Console.ReadLine();
                Context.SaveChanges();
            }
        }
    }
}
