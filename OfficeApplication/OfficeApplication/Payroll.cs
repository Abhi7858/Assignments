using System;

namespace OfficeApplication
{
    public class Payroll : Department
    {
        public void UpdateSalary(int updateSalaryId)
        {
            var Context = new EmployeeEntities();
            var Employee = Context.TblEmployees.Find(updateSalaryId);
            if (Employee != null)
            {
                Console.Write("Update Salary of {0}: ", Employee.EmployeeName);
                Employee.Salary = Convert.ToInt32(Console.ReadLine());
                Context.SaveChanges();
            }
        }

    }
}
