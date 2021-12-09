namespace OfficeApplication
{
    interface IEmployeeManagementService
    {
        void AddEmployee(TblEmployee employee);
        void UpdateEmployee(int employeeId);
        void RemoveEmployee(int employeeId);

    }
}
