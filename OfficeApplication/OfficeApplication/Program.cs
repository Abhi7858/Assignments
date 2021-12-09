using System;

namespace OfficeApplication
{
    class Program
    {
        public  static void DepartmentWiseDisplay(string department)
        {
            var Context = new EmployeeEntities();
            Console.WriteLine("Employee Id" + " | " + "Employee Name" + " | " + "Employee Address" + " | " + "Department Name" + " | " + "Salary");
            foreach (var Employee in Context.TblEmployees)
            {
                if (Employee.DepartmentName == department)
                Console.WriteLine(Employee.EmployeeId + " | " + Employee.EmployeeName + " | " + Employee.EmployeeAddress + " | " + Employee.DepartmentName + " | " + Employee.Salary);
            }
        }
        public static void DisplayTotalEmployees()
        {
            var Context = new EmployeeEntities();
            Console.WriteLine("Employee Id" + " | " + "Employee Name" + " | " + "Employee Address" + " | " + "Department Name" + " | " + "Salary");
            foreach (var Employee in Context.TblEmployees)
            Console.WriteLine(Employee.EmployeeId + " | " + Employee.EmployeeName + " | " + Employee.EmployeeAddress + " | " + Employee.DepartmentName + " | " + Employee.Salary);
            
        }
        public static int GetEmployeeId()
        {
            Console.Write("Enter Employee Id : ");
            int getId = Convert.ToInt32(Console.ReadLine());
            return getId;
        }
        public static TblEmployee EnterEmployeeDetails()
        {
            int id;
            decimal salary;
            string name, deptName, address;
            Console.Write("Enter Employee Id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Department Name: ");
            deptName = Console.ReadLine();
            Console.Write("Enter Employee Address: ");
            address = Console.ReadLine();
            Console.Write("Enter Employee Salary: ");
            salary = Convert.ToInt32(Console.ReadLine());
            var employee = new TblEmployee
            {
                EmployeeId = id,
                EmployeeName = name,
                DepartmentName = deptName,
                EmployeeAddress = address,
                Salary = salary
            };
            return employee;
        }
        static void Main(string[] args)
        {
            int choice,updateId,removeId,updateSalaryId;

            do
            {
                Console.WriteLine("1. Add An Employee.");
                Console.WriteLine("2. Update An Employee(Name,Adress,Department).");
                Console.WriteLine("3. Update Employees Salary.");
                Console.WriteLine("4. Remove An Employee.");
                Console.WriteLine("5. Display Employees Departmentwise.");
                Console.WriteLine("6. Display All Employees.");
                Console.WriteLine("0. Exit.");
                Console.Write("Enter Your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                IEmployeeManagementService addEmp = new Administration();

                switch (choice)
                {
                    case 1:
                        var getEmployee = EnterEmployeeDetails();
                        addEmp.AddEmployee(getEmployee);
                        break;
                    case 2:
                        updateId = GetEmployeeId();                       
                        addEmp.UpdateEmployee(updateId);                       
                        break;
                    case 3:
                        updateSalaryId = GetEmployeeId();
                        Payroll updateSalary = new Payroll();
                        updateSalary.UpdateSalary(updateSalaryId);                                              
                        break;
                    case 4:
                        removeId = GetEmployeeId();
                        addEmp.RemoveEmployee(removeId);
                        break;
                    case 5:                       
                        Console.Write("Enter Department to Display Employees: ");
                        string department = Console.ReadLine();
                        DepartmentWiseDisplay(department);
                        break;
                    case 6:
                        DisplayTotalEmployees();
                        break;
                    case 0:
                        Console.WriteLine("Thank You.....");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (choice != 0);
        }
    }
}
