using System;

namespace OfficeApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            int choice,employeeId;
            OfficeUtil officeUtil = new OfficeUtil();

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
                        var getEmployee = officeUtil.GetEmployeeDetails();
                        addEmp.AddEmployee(getEmployee);
                        break;
                    case 2:
                        employeeId = officeUtil.GetEmployeeId();                       
                        addEmp.UpdateEmployee(employeeId);                       
                        break;
                    case 3:
                        employeeId = officeUtil.GetEmployeeId();
                        Payroll updateSalary = new Payroll();
                        updateSalary.UpdateSalary(employeeId);                                              
                        break;
                    case 4:
                        employeeId = officeUtil.GetEmployeeId();
                        addEmp.RemoveEmployee(employeeId);
                        break;
                    case 5:
                        Console.WriteLine("Select Department to Display: ");
                        officeUtil.DepartmentList();
                        Console.Write("Enter Department Id: ");
                        int departmentId = Convert.ToInt32(Console.ReadLine());
                        officeUtil.DepartmentWiseDisplay(departmentId);
                        break;
                    case 6:
                        officeUtil.DisplayTotalEmployees();
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
