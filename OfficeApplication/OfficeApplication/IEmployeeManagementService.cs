namespace OfficeApplication
{
    interface IEmployeeManagementService
    {
        void AddEmployee(Employee employee);
        void UpdateEmployee(int employeeId);
        void RemoveEmployee(int employeeId);
    }
}
