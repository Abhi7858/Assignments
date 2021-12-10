using System;

namespace OfficeApplication
{
    class OfficeUtil
    {
        public  Employee GetEmployeeDetails()
        {
            int id, deptId;
            decimal salary;
            string name,address;
            Console.Write("Enter Employee Id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Employee Address: ");
            address = Console.ReadLine();
            Console.Write("Enter Employee Salary: ");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select Department Id: ");
            Console.WriteLine("1. Administration");
            Console.WriteLine("2. Payroll");
            Console.WriteLine("3. R&D");
            Console.WriteLine("4. Technical");
            Console.WriteLine("5. Help and Support");
            Console.Write("Enter Department Id: ");
            deptId = Convert.ToInt32(Console.ReadLine());
            var employee = new Employee
            {
                EmployeeId = id,
                EmployeeName = name,
                DepartmentId = deptId,
                EmployeeAddress = address,
                Salary = salary
            };
            return employee;
        }
        public void DepartmentWiseDisplay(int departmentId)
        {
            var Context = new EmployeeEntities1();
            Console.WriteLine("Employee Id" + " | " + "Employee Name" + " | " + "Employee Address" + " | " + "Department Id" + " | " + "Salary");
            foreach (Employee employee in Context.Employees)
            {
                if (employee.DepartmentId == departmentId)
                    Console.WriteLine(employee.EmployeeId + " | " + employee.EmployeeName + " | " + employee.EmployeeAddress + " | " + employee.DepartmentId + " | " + employee.Salary);
            }
        }
        public void DisplayTotalEmployees()
        {
            var Context = new EmployeeEntities1();
            Console.WriteLine("Employee Id" + " | " + "Employee Name" + " | " + "Employee Address" + " | " + "Department Id" + " | " + "Salary");
            foreach (var employee in Context.Employees)
                Console.WriteLine(employee.EmployeeId + " | " + employee.EmployeeName + " | " + employee.EmployeeAddress + " | " + employee.DepartmentId + " | " + employee.Salary);
        }
        public int GetEmployeeId()
        {
            Console.Write("Enter Employee Id : ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
