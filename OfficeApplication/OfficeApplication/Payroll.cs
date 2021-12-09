using System;

namespace OfficeApplication
{
    public class Payroll : Department
    {
        public void UpdateSalary(int employeeId)
        {
            var Context = new EmployeeEntities();
            var Employee = Context.TblEmployees.Find(employeeId);
            if (Employee != null)
            {
                Console.Write("Update Salary of {0}: ", Employee.EmployeeName);
                Employee.Salary = Convert.ToInt32(Console.ReadLine());
                Context.SaveChanges();
            }
        }

    }
}
